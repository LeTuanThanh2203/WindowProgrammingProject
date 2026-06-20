using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ProjectMonHoc;


namespace LoginForm
{
    public partial class f_Schedule : Form
    {
        // ── Cached fonts (created once, reused everywhere) ─────────────────────
        private static readonly Font _fontCourseTitle = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
        private static readonly Font _fontCardInfo    = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
        private static readonly Font _fontCardDetail  = new Font("Segoe UI", 9.5F);
        private static readonly Font _fontDayHeader   = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        private static readonly Font _fontGridHeader  = new Font("Segoe UI", 12F, FontStyle.Bold);

        // ── Cached DB data ─────────────────────────────────────────────────────
        private List<ScheduleItem> _cachedItems = null;
        private string _cachedYear = null;
        private string _cachedSemester = null;

        // ── Pre-created card panels: [day 0-6, session 0-2, card 0-2] ───────────
        private const int MAX_CARDS_PER_CELL = 3;
        private Panel[,,] _cardPanels;         // the card container
        private Label[,,] _cardTitleLabels;     // course name (red)
        private Label[,,] _cardInfoLabels;      // class | room (green)
        private Label[,,] _cardDetailLabels;    // GV | periods (blue)
        private FlowLayoutPanel[,] _cellFlps;   // FlowLayoutPanel per cell
        private bool _gridBuilt = false;

        public f_Schedule()
        {
            InitializeComponent();

            this.cboYear.SelectedIndexChanged += cboYear_SelectedIndexChanged;
            this.cboSemester.SelectedIndexChanged += cboSemester_SelectedIndexChanged;
            this.cboWeek.SelectedIndexChanged += cboWeek_SelectedIndexChanged;
            this.btnPrevWeek.Click += btnPrevWeek_Click;
            this.btnNextWeek.Click += btnNextWeek_Click;
            this.btnCurrentWeek.Click += btnCurrentWeek_Click;
            this.btnPrintSchedule.Click += btnPrintSchedule_Click;

            SetupButtonHover(btnPrevWeek);
            SetupButtonHover(btnCurrentWeek);
            SetupButtonHover(btnNextWeek);
            SetupButtonHover(btnPrintSchedule);

            this.Load += f_Schedule_Load;
        }

        private async void f_Schedule_Load(object sender, EventArgs e)
        {
            tlpGrid.AutoSize = false;

            // Blue left border accent on week info bar
            pnlWeekInfo.Paint += (s, pe) =>
            {
                using (var pen = new Pen(Color.FromArgb(10, 61, 120), 4))
                    pe.Graphics.DrawLine(pen, 0, 0, 0, pnlWeekInfo.Height);
            };

            BuildFixedGrid();
            await LoadAcademicYearsAsync();
        }

        // ══════════ BUILD GRID ONCE (pre-create all cards) ═════════════════
        private void BuildFixedGrid()
        {
            if (_gridBuilt) return;
            _gridBuilt = true;

            tlpGrid.SuspendLayout();

            // Columns: Day (110px) + 3 sessions
            tlpGrid.ColumnStyles.Clear();
            tlpGrid.ColumnCount = 4;
            tlpGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tlpGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));

            // Rows: Header (45px) + 7 day rows (130px each)
            tlpGrid.RowStyles.Clear();
            tlpGrid.RowCount = 8;
            tlpGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            for (int i = 0; i < 7; i++)
                tlpGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tlpGrid.Height = 45 + 7 * 130;

            // ── Row 0 headers ──
            string[] headers = { "Day", "Morning", "Afternoon", "Evening" };
            for (int c = 0; c < 4; c++)
            {
                var lbl = new Label
                {
                    Text      = headers[c],
                    Font      = _fontGridHeader,
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(10, 61, 120),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock      = DockStyle.Fill,
                    Margin    = new Padding(0)
                };
                tlpGrid.Controls.Add(lbl, c, 0);
            }

            // ── Day labels (col 0, rows 1-7) ──
            string[] dayNames = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i = 0; i < 7; i++)
            {
                var lblDay = new Label
                {
                    Text      = dayNames[i],
                    Font      = _fontDayHeader,
                    ForeColor = Color.FromArgb(10, 61, 120),
                    BackColor = Color.FromArgb(230, 240, 250),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock      = DockStyle.Fill,
                    Margin    = new Padding(0)
                };
                tlpGrid.Controls.Add(lblDay, 0, i + 1);
            }

            // ── Pre-create FlowLayoutPanels + Card Panels ──
            _cellFlps        = new FlowLayoutPanel[7, 3];
            _cardPanels      = new Panel[7, 3, MAX_CARDS_PER_CELL];
            _cardTitleLabels = new Label[7, 3, MAX_CARDS_PER_CELL];
            _cardInfoLabels  = new Label[7, 3, MAX_CARDS_PER_CELL];
            _cardDetailLabels= new Label[7, 3, MAX_CARDS_PER_CELL];

            for (int r = 0; r < 7; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    var flp = new FlowLayoutPanel
                    {
                        FlowDirection = FlowDirection.TopDown,
                        WrapContents  = false,
                        AutoScroll    = true,
                        Dock          = DockStyle.Fill,
                        Padding       = new Padding(3),
                        BackColor     = Color.White,
                        Margin        = new Padding(0)
                    };
                    _cellFlps[r, c] = flp;
                    tlpGrid.Controls.Add(flp, c + 1, r + 1);

                    for (int k = 0; k < MAX_CARDS_PER_CELL; k++)
                    {
                        // Title label (course name - red)
                        var lblTitle = new Label
                        {
                            Font      = _fontCourseTitle,
                            ForeColor = Color.FromArgb(220, 53, 69),
                            TextAlign = ContentAlignment.MiddleLeft,
                            Dock      = DockStyle.Top,
                            Height    = 22,
                            Padding   = new Padding(4, 2, 0, 0),
                            AutoEllipsis = true
                        };

                        // Info label (class | room - green)
                        var lblInfo = new Label
                        {
                            Font      = _fontCardInfo,
                            ForeColor = Color.FromArgb(40, 167, 69),
                            TextAlign = ContentAlignment.MiddleLeft,
                            Dock      = DockStyle.Top,
                            Height    = 20,
                            Padding   = new Padding(4, 0, 0, 0),
                            AutoEllipsis = true
                        };

                        // Detail label (GV | periods - blue)
                        var lblDetail = new Label
                        {
                            Font      = _fontCardDetail,
                            ForeColor = Color.FromArgb(10, 61, 120),
                            TextAlign = ContentAlignment.MiddleLeft,
                            Dock      = DockStyle.Top,
                            Height    = 20,
                            Padding   = new Padding(4, 0, 0, 2),
                            AutoEllipsis = true
                        };

                        // Card panel container
                        var card = new Panel
                        {
                            Width       = 200,
                            Height      = 68,
                            BackColor   = Color.FromArgb(225, 240, 255),
                            BorderStyle = BorderStyle.FixedSingle,
                            Margin      = new Padding(0, 0, 0, 3),
                            Padding     = new Padding(0),
                            Visible     = false
                        };

                        // Add in reverse order (Dock.Top stacks bottom-to-top)
                        card.Controls.Add(lblDetail);
                        card.Controls.Add(lblInfo);
                        card.Controls.Add(lblTitle);

                        _cardPanels[r, c, k]       = card;
                        _cardTitleLabels[r, c, k]  = lblTitle;
                        _cardInfoLabels[r, c, k]   = lblInfo;
                        _cardDetailLabels[r, c, k] = lblDetail;

                        flp.Controls.Add(card);
                    }

                    // Resize cards when FlowLayoutPanel resizes
                    flp.ClientSizeChanged += (s, _) =>
                    {
                        var fp = (FlowLayoutPanel)s;
                        int w = Math.Max(100, fp.ClientSize.Width - 10);
                        foreach (Control ctrl in fp.Controls)
                            if (ctrl is Panel p) p.Width = w;
                    };
                }
            }

            tlpGrid.ResumeLayout(true);
        }


        private void SetupButtonHover(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(10, 61, 120);
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 80, 150);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 45, 90);
        }

        // ================= SMART DEFAULT SELECTION =================
        private void FindDefaultSemesterWithClasses(out string year, out string semester)
        {
            year = "";
            semester = "";
            string query = @"
                SELECT TOP 1 cl.AcademicYear, cl.Semester
                FROM DKMH d
                JOIN Class cl ON d.ClassID = cl.ClassID
                WHERE d.ID = @studentId
                ORDER BY cl.AcademicYear DESC, cl.Semester DESC";

            using (var db = new My_DB())
            {
                try
                {
                    db.openConnection();
                    using (var cmd = new SqlCommand(query, db.getConnection))
                    {
                        cmd.Parameters.Add("@studentId", SqlDbType.VarChar, 20).Value = Globals.Username;
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                year = reader["AcademicYear"].ToString();
                                semester = reader["Semester"].ToString();
                            }
                        }
                    }
                }
                catch { }
                finally
                {
                    db.closeConnection();
                }
            }
        }

        // ================= LOAD YEAR COMBO =================
        private async Task LoadAcademicYearsAsync()
        {
            cboYear.SelectedIndexChanged -= cboYear_SelectedIndexChanged;
            cboYear.Items.Clear();

            // Fetch years + default semester from DB off the UI thread
            string defaultYear = "";
            string defaultSemester = "";
            List<string> years = new List<string>();

            await Task.Run(() =>
            {
                try
                {
                    var cl = new Class();
                    DataTable dt = cl.GetDistinctAcademicYears();
                    foreach (DataRow row in dt.Rows)
                        years.Add(row["AcademicYear"].ToString());
                }
                catch { }

                FindDefaultSemesterWithClasses(out defaultYear, out defaultSemester);
            });

            foreach (var y in years)
                cboYear.Items.Add(y);

            if (cboYear.Items.Count == 0)
            {
                cboYear.Items.Add("2024-2025");
                cboYear.Items.Add("2025-2026");
            }

            if (!string.IsNullOrEmpty(defaultYear) && cboYear.Items.Contains(defaultYear))
                cboYear.SelectedItem = defaultYear;
            else if (cboYear.Items.Count > 0)
                cboYear.SelectedIndex = 0;

            cboYear.SelectedIndexChanged += cboYear_SelectedIndexChanged;
            await LoadSemestersAsync(defaultSemester);
        }


        // ================= LOAD SEMESTER COMBO =================
        private async Task LoadSemestersAsync(string defaultSemester = "")
        {
            cboSemester.SelectedIndexChanged -= cboSemester_SelectedIndexChanged;
            cboSemester.Items.Clear();

            if (cboYear.SelectedItem == null)
            {
                cboSemester.SelectedIndexChanged += cboSemester_SelectedIndexChanged;
                return;
            }

            string selectedYear = cboYear.SelectedItem.ToString();
            List<string> semesters = new List<string>();

            await Task.Run(() =>
            {
                try
                {
                    var cl = new Class();
                    DataTable dt = cl.GetSemestersByYear(selectedYear);
                    foreach (DataRow row in dt.Rows)
                        semesters.Add(row["Semester"].ToString());
                }
                catch { }
            });

            foreach (var s in semesters)
                cboSemester.Items.Add(s);

            if (cboSemester.Items.Count == 0)
            {
                cboSemester.Items.Add("Semester 1");
                cboSemester.Items.Add("Semester 2");
                cboSemester.Items.Add("Summer");
            }

            if (!string.IsNullOrEmpty(defaultSemester) && cboSemester.Items.Contains(defaultSemester))
                cboSemester.SelectedItem = defaultSemester;
            else if (cboSemester.Items.Count > 0)
                cboSemester.SelectedIndex = 0;

            cboSemester.SelectedIndexChanged += cboSemester_SelectedIndexChanged;
            LoadWeeks(); // weeks are calendar-computed (no DB), stays sync
        }


        // ================= LOAD WEEK COMBO =================
        private void LoadWeeks()
        {
            cboWeek.SelectedIndexChanged -= cboWeek_SelectedIndexChanged;
            cboWeek.Items.Clear();

            if (cboYear.SelectedItem == null || cboSemester.SelectedItem == null)
            {
                cboWeek.SelectedIndexChanged += cboWeek_SelectedIndexChanged;
                return;
            }

            string yearStr = cboYear.SelectedItem.ToString();
            string semesterStr = cboSemester.SelectedItem.ToString();

            int startYear = 2025;
            int endYear = 2026;
            var yearParts = yearStr.Split('-');
            if (yearParts.Length == 2)
            {
                int.TryParse(yearParts[0], out startYear);
                int.TryParse(yearParts[1], out endYear);
            }

            DateTime semesterStart = GetSemesterStart(semesterStr, startYear, endYear);
            // Semester 1 = 15 weeks, Semester 2 = 15 weeks, Summer = 7 weeks
            int weekCount = (semesterStr == "Summer") ? 7 : 15;

            int defaultSelectIndex = 0;
            DateTime today = DateTime.Today;

            for (int i = 0; i < weekCount; i++)
            {
                DateTime weekStart = semesterStart.AddDays(i * 7);
                DateTime weekEnd = weekStart.AddDays(6);
                string weekText = $"Week {i + 1}: {weekStart.ToString("dd/MM/yyyy")}-{weekEnd.ToString("dd/MM/yyyy")}";
                cboWeek.Items.Add(weekText);

                if (today >= weekStart && today <= weekEnd)
                {
                    defaultSelectIndex = i;
                }
            }

            if (cboWeek.Items.Count > 0)
            {
                cboWeek.SelectedIndex = defaultSelectIndex;
            }

            cboWeek.SelectedIndexChanged += cboWeek_SelectedIndexChanged;
            RenderSchedule();
        }

        /// <summary>
        /// Calculates the start date of a semester based on the academic year and semester name.
        /// - Semester 1: 1st Monday of September (startYear), 15 weeks
        /// - Semester 2: Semester 1 end + 1 break week, 15 weeks
        /// - Summer:     Semester 2 end + 1 break week, 7 weeks
        /// </summary>
        private DateTime GetSemesterStart(string semesterStr, int startYear, int endYear)
        {
            // Semester 1 begins on the first Monday of September
            DateTime sem1Start = GetFirstMonday(startYear, 9);

            if (semesterStr == "Semester 1")
                return sem1Start;

            // Semester 2 = Semester 1 (15 weeks) + 1 break week
            DateTime sem2Start = sem1Start.AddDays(15 * 7 + 7);

            if (semesterStr == "Semester 2")
                return sem2Start;

            // Summer = Semester 2 (15 weeks) + 1 break week
            DateTime summerStart = sem2Start.AddDays(15 * 7 + 7);
            return summerStart;
        }

        private DateTime GetFirstMonday(int year, int month)
        {
            DateTime dt = new DateTime(year, month, 1);
            while (dt.DayOfWeek != DayOfWeek.Monday)
            {
                dt = dt.AddDays(1);
            }
            return dt;
        }

        private async void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cachedItems = null; // invalidate cache when year changes
            await LoadSemestersAsync();
        }

        private async void cboSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cachedItems = null; // invalidate cache when semester changes
            LoadWeeks(); // sync - no DB
        }

        private void cboWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenderSchedule();
        }

        // ================= NAVIGATION BUTTONS =================
        private void btnPrevWeek_Click(object sender, EventArgs e)
        {
            if (cboWeek.SelectedIndex > 0)
            {
                cboWeek.SelectedIndex--;
            }
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            if (cboWeek.SelectedIndex < cboWeek.Items.Count - 1)
            {
                cboWeek.SelectedIndex++;
            }
        }

        private void btnCurrentWeek_Click(object sender, EventArgs e)
        {
            if (cboWeek.Items.Count == 0) return;

            string selectedYear = cboYear.SelectedItem?.ToString() ?? "";
            string selectedSemester = cboSemester.SelectedItem?.ToString() ?? "";
            int startYear = 2025;
            int endYear = 2026;
            var yearParts = selectedYear.Split('-');
            if (yearParts.Length == 2)
            {
                int.TryParse(yearParts[0], out startYear);
                int.TryParse(yearParts[1], out endYear);
            }

            DateTime semesterStart = GetSemesterStart(selectedSemester, startYear, endYear);
            int weekCount = (selectedSemester == "Summer") ? 7 : 15;

            DateTime today = DateTime.Today;
            for (int i = 0; i < weekCount; i++)
            {
                DateTime weekStart = semesterStart.AddDays(i * 7);
                DateTime weekEnd = weekStart.AddDays(6);
                if (today >= weekStart && today <= weekEnd)
                {
                    cboWeek.SelectedIndex = i;
                    return;
                }
            }
            cboWeek.SelectedIndex = 0;
        }

        // ═══════════════ RENDER SCHEDULE (update pre-created cards) ════════════
        private async void RenderSchedule()
        {
            if (cboWeek.SelectedItem == null) return;
            string selectedWeek = cboWeek.SelectedItem.ToString();

            // Parse weekStart from combo (format: "Week N: dd/MM/yyyy-dd/MM/yyyy")
            string datePart = selectedWeek.Contains(": ")
                ? selectedWeek.Substring(selectedWeek.IndexOf(": ") + 2)
                : selectedWeek;
            var parts = datePart.Split('-');
            if (parts.Length < 2) return;
            DateTime weekStart;
            if (!DateTime.TryParseExact(parts[0].Trim(), "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out weekStart)) return;

            DateTime weekEnd = weekStart.AddDays(6);
            string selectedSemester = cboSemester.SelectedItem?.ToString() ?? "";
            int totalWeeksInt = selectedSemester == "Summer" ? 7 : 15;

            // Update week info bar (designer's lblWeekRange)
            lblWeekRange.Text = $"  📅  {weekStart:dd/MM/yyyy}  —  {weekEnd:dd/MM/yyyy}     |     Week {cboWeek.SelectedIndex + 1} of {totalWeeksInt}";

            string selectedYear = cboYear.SelectedItem?.ToString() ?? "";
            int weekIndex       = cboWeek.SelectedIndex + 1;
            string studentId    = Globals.Username;

            // ── Fetch DB only when year/semester changes ───────────────────────
            if (_cachedItems == null ||
                _cachedYear != selectedYear ||
                _cachedSemester != selectedSemester)
            {
                _cachedItems = await Task.Run(() =>
                    GetScheduleItems(studentId, selectedYear, selectedSemester));
                _cachedYear     = selectedYear;
                _cachedSemester = selectedSemester;
            }

            // ── Build card data per cell ─────────────────────────────────────
            // cardData[day, session] = list of (title, info, detail)
            var cardData = new List<(string title, string info, string detail)>[7, 3];
            for (int r = 0; r < 7; r++)
                for (int c = 0; c < 3; c++)
                    cardData[r, c] = new List<(string, string, string)>();

            double totalWeeks = totalWeeksInt;

            foreach (var item in _cachedItems)
            {
                if (string.IsNullOrWhiteSpace(item.Schedule)) continue;
                var schedParts = item.Schedule.Split(' ');
                if (schedParts.Length < 2) continue;

                string[] days  = schedParts[0].Split('/');
                string[] times = schedParts[1].Split('-');
                if (times.Length < 2) continue;

                string startTimeStr = times[0];
                string endTimeStr   = times[1];

                int sCol = 0;
                if (TimeSpan.TryParse(startTimeStr, out TimeSpan startTs))
                {
                    if      (startTs >= new TimeSpan(17, 0, 0)) sCol = 2;
                    else if (startTs >= new TimeSpan(12, 0, 0)) sCol = 1;
                }

                string periodStr   = GetPeriodsFromTime(startTimeStr, endTimeStr);
                int studiedPeriods = (int)Math.Round(item.TotalPeriods *
                    Math.Min(weekIndex / totalWeeks, 1.0));

                string title  = $"● {item.CourseName} ({item.CourseID})";
                string info   = $"Class: {item.ClassID}  |  Room: {item.Room}";
                string detail = $"GV: {item.LecturerName}  |  Periods: {periodStr}";

                foreach (var day in days)
                {
                    int dRow = GetRowIndexFromDay(day) - 1;
                    if (dRow < 0 || dRow > 6) continue;
                    cardData[dRow, sCol].Add((title, info, detail));
                }
            }

            // ── Apply to pre-created cards (show/hide + set text) ─────────────
            for (int r = 0; r < 7; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    var items = cardData[r, c];
                    for (int k = 0; k < MAX_CARDS_PER_CELL; k++)
                    {
                        if (k < items.Count)
                        {
                            _cardTitleLabels[r, c, k].Text  = items[k].title;
                            _cardInfoLabels[r, c, k].Text   = items[k].info;
                            _cardDetailLabels[r, c, k].Text = items[k].detail;
                            _cardPanels[r, c, k].Visible    = true;
                        }
                        else
                        {
                            _cardPanels[r, c, k].Visible = false;
                        }
                    }
                }
            }
        }


        // ================= DATABASE QUERY AND PARSING HELPER =================
        private class ScheduleItem
        {
            public string ClassID { get; set; }
            public string CourseID { get; set; }
            public string CourseName { get; set; }
            public int Credits { get; set; }
            public string Room { get; set; }
            public string Schedule { get; set; }
            public string LecturerName { get; set; }
            public int TotalPeriods { get; set; }
        }

        private List<ScheduleItem> GetScheduleItems(string studentId, string year, string semester)
        {
            var list = new List<ScheduleItem>();
            string query = @"
                SELECT cl.ClassID, cl.CourseID, co.CourseName, co.Credits, cl.Room, cl.Schedule,
                       (SELECT TOP 1 (h.FirstName + ' ' + h.LastName)
                        FROM Assign a
                        JOIN HR h ON a.HRID = h.ID
                        WHERE a.CourseID = co.CourseID) AS LecturerName,
                       co.TotalPeriods
                FROM DKMH d
                JOIN Class cl ON d.ClassID = cl.ClassID
                JOIN Course co ON cl.CourseID = co.CourseID
                WHERE d.ID = @studentId AND cl.AcademicYear = @year AND cl.Semester = @semester";

            using (var db = new My_DB())
            {
                try
                {
                    db.openConnection();
                    using (var cmd = new SqlCommand(query, db.getConnection))
                    {
                        cmd.Parameters.Add("@studentId", SqlDbType.VarChar, 20).Value = studentId;
                        cmd.Parameters.Add("@year", SqlDbType.VarChar, 20).Value = year;
                        cmd.Parameters.Add("@semester", SqlDbType.NVarChar, 20).Value = semester;

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new ScheduleItem
                                {
                                    ClassID = reader["ClassID"].ToString(),
                                    CourseID = reader["CourseID"].ToString(),
                                    CourseName = reader["CourseName"].ToString(),
                                    Credits = Convert.ToInt32(reader["Credits"]),
                                    Room = reader["Room"]?.ToString() ?? "",
                                    Schedule = reader["Schedule"]?.ToString() ?? "",
                                    LecturerName = reader["LecturerName"]?.ToString() ?? "TBA",
                                    TotalPeriods = Convert.ToInt32(reader["TotalPeriods"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading schedule: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.closeConnection();
                }
            }
            return list;
        }

        private int GetRowIndexFromDay(string day)
        {
            switch (day.Trim().ToLower())
            {
                case "mon": return 1;
                case "tue": return 2;
                case "wed": return 3;
                case "thu": return 4;
                case "fri": return 5;
                case "sat": return 6;
                case "sun": return 7;
                default: return -1;
            }
        }

        private string GetPeriodsFromTime(string startTimeStr, string endTimeStr)
        {
            try
            {
                TimeSpan start = TimeSpan.Parse(startTimeStr);
                TimeSpan end = TimeSpan.Parse(endTimeStr);

                int startPeriod = 1;

                if (start < new TimeSpan(8, 0, 0)) startPeriod = 1;
                else if (start >= new TimeSpan(8, 0, 0) && start < new TimeSpan(9, 0, 0)) startPeriod = 2;
                else if (start >= new TimeSpan(9, 0, 0) && start < new TimeSpan(9, 50, 0)) startPeriod = 3;
                else if (start >= new TimeSpan(9, 50, 0) && start < new TimeSpan(10, 50, 0)) startPeriod = 4;
                else if (start >= new TimeSpan(10, 50, 0) && start < new TimeSpan(12, 0, 0)) startPeriod = 5;
                else if (start >= new TimeSpan(12, 0, 0) && start < new TimeSpan(13, 10, 0)) startPeriod = 6;
                else if (start >= new TimeSpan(13, 10, 0) && start < new TimeSpan(14, 10, 0)) startPeriod = 7;
                else if (start >= new TimeSpan(14, 10, 0) && start < new TimeSpan(15, 10, 0)) startPeriod = 8;
                else if (start >= new TimeSpan(15, 10, 0) && start < new TimeSpan(16, 10, 0)) startPeriod = 9;
                else if (start >= new TimeSpan(16, 10, 0) && start < new TimeSpan(17, 10, 0)) startPeriod = 10;
                else startPeriod = 11;

                double durationHours = (end - start).TotalHours;
                int numPeriods = (int)Math.Round(durationHours / 0.85); // Approx 50 minutes per period
                if (numPeriods < 1) numPeriods = 1;
                int endPeriod = startPeriod + numPeriods - 1;

                if (startPeriod == endPeriod)
                    return $"{startPeriod}";
                else
                    return $"{startPeriod}->{endPeriod}";
            }
            catch
            {
                return "1->2";
            }
        }

        // ================= WORD DOCUMENT EXPORTING =================
        private void btnPrintSchedule_Click(object sender, EventArgs e)
        {
            if (cboWeek.SelectedItem == null) return;
            string selectedWeek = cboWeek.SelectedItem.ToString();

            var saveDialog = new SaveFileDialog
            {
                Filter = "Word Document|*.docx",
                Title = "Save Schedule As Word Document",
                FileName = $"Schedule_{cboYear.SelectedItem?.ToString()}_{cboSemester.SelectedItem?.ToString()}_Week_{cboWeek.SelectedIndex + 1}.docx"
            };

            if (saveDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (Xceed.Words.NET.DocX doc = Xceed.Words.NET.DocX.Create(saveDialog.FileName))
                {
                    Xceed.Document.NET.Paragraph titlePara = doc.InsertParagraph("STUDENT WEEKLY SCHEDULE");
                    titlePara.FontSize(18).Bold().Alignment = Xceed.Document.NET.Alignment.center;
                    titlePara.SpacingAfter(10);

                    Xceed.Document.NET.Paragraph metaPara = doc.InsertParagraph();
                    metaPara.FontSize(10.5).Alignment = Xceed.Document.NET.Alignment.center;
                    metaPara.Append("Student: ").Bold().Append($"{Globals.Username}    |    ");
                    metaPara.Append("Academic Year: ").Bold().Append($"{cboYear.SelectedItem?.ToString()}    |    ");
                    metaPara.Append("Semester: ").Bold().Append($"{cboSemester.SelectedItem?.ToString()}\n");
                    metaPara.Append("Week: ").Bold().Append($"{selectedWeek} (Week {cboWeek.SelectedIndex + 1})");
                    metaPara.SpacingAfter(20);

                    Xceed.Document.NET.Table table = doc.AddTable(8, 4);
                    table.Design = Xceed.Document.NET.TableDesign.TableGrid;
                    table.Alignment = Xceed.Document.NET.Alignment.center;
                    table.SetWidths(new float[] { 100f, 180f, 180f, 180f });

                    string[] headers = { "Day / Date", "Morning (Start < 12:00)", "Afternoon (12:00 - 16:59)", "Evening (Start >= 17:00)" };
                    for (int col = 0; col < 4; col++)
                    {
                        Xceed.Document.NET.Cell cell = table.Rows[0].Cells[col];
                        cell.FillColor = Xceed.Drawing.Color.Parse(10, 61, 120);
                        Xceed.Document.NET.Paragraph p = cell.Paragraphs[0];
                        p.Append(headers[col]).Bold().Color(Xceed.Drawing.Color.Parse(255, 255, 255)).Alignment = Xceed.Document.NET.Alignment.center;
                    }

                    var parts = selectedWeek.Contains(": ")
                        ? selectedWeek.Substring(selectedWeek.IndexOf(": ") + 2).Split('-')
                        : selectedWeek.Split('-');
                    DateTime weekStart = DateTime.ParseExact(parts[0].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    string[] dayNames = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

                    string studentId = Globals.Username;
                    string selectedYear = cboYear.SelectedItem?.ToString() ?? "";
                    string selectedSemester = cboSemester.SelectedItem?.ToString() ?? "";
                    int weekIndex = cboWeek.SelectedIndex + 1;

                    var scheduleItems = GetScheduleItems(studentId, selectedYear, selectedSemester);



                    for (int dayIdx = 0; dayIdx < 7; dayIdx++)
                    {
                        DateTime dayDate = weekStart.AddDays(dayIdx);
                        int rowIndex = dayIdx + 1;

                        Xceed.Document.NET.Cell dayCell = table.Rows[rowIndex].Cells[0];
                        dayCell.FillColor = Xceed.Drawing.Color.Parse(230, 240, 250); // Soft Blue matching UI Day cell
                        Xceed.Document.NET.Paragraph dayPara = dayCell.Paragraphs[0];
                        dayPara.Append($"{dayNames[dayIdx]}\n({dayDate.ToString("dd/MM/yyyy")})").Bold().Alignment = Xceed.Document.NET.Alignment.center;

                        var morningClasses = new List<string>();
                        var afternoonClasses = new List<string>();
                        var eveningClasses = new List<string>();

                        foreach (var item in scheduleItems)
                        {
                            if (string.IsNullOrWhiteSpace(item.Schedule)) continue;

                            var schedParts = item.Schedule.Split(' ');
                            if (schedParts.Length < 2) continue;

                            string daysStr = schedParts[0];
                            string timeStr = schedParts[1];

                            var days = daysStr.Split('/');
                            var times = timeStr.Split('-');
                            if (times.Length < 2) continue;

                            string startTimeStr = times[0];
                            string endTimeStr = times[1];

                            bool meetsOnDay = false;
                            foreach (var d in days)
                            {
                                if (GetRowIndexFromDay(d) == rowIndex)
                                {
                                    meetsOnDay = true;
                                    break;
                                }
                            }

                            if (!meetsOnDay) continue;

                            string periodStr = GetPeriodsFromTime(startTimeStr, endTimeStr);
                            double totalWeeksExport = (selectedSemester == "Summer") ? 7.0 : 15.0;
                            int studiedPeriods = (int)Math.Round(item.TotalPeriods * Math.Min((double)weekIndex / totalWeeksExport, 1.0));

                            string classInfo = $"Course: {item.CourseName} ({item.CourseID})\n" +
                                               $"Class: {item.ClassID}\n" +
                                               $"Periods: {periodStr}\n" +
                                               $"Room: {item.Room}\n" +
                                               $"Lecturer: {item.LecturerName}\n" +
                                               $"Progress: {studiedPeriods}/{item.TotalPeriods} periods\n" +
                                               $"Contents:\n" +
                                               $"---------------------------------------------";

                            try
                            {
                                TimeSpan startTime = TimeSpan.Parse(startTimeStr);
                                if (startTime < new TimeSpan(12, 0, 0))
                                    morningClasses.Add(classInfo);
                                else if (startTime < new TimeSpan(17, 0, 0))
                                    afternoonClasses.Add(classInfo);
                                else
                                    eveningClasses.Add(classInfo);
                            }
                            catch
                            {
                                morningClasses.Add(classInfo);
                            }
                        }

                        WriteClassesToCell(table.Rows[rowIndex].Cells[1], morningClasses);
                        WriteClassesToCell(table.Rows[rowIndex].Cells[2], afternoonClasses);
                        WriteClassesToCell(table.Rows[rowIndex].Cells[3], eveningClasses);
                    }

                    doc.InsertTable(table);
                    doc.Save();
                }

                MessageBox.Show("Schedule exported successfully!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting schedule: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteClassesToCell(Xceed.Document.NET.Cell cell, List<string> classes)
        {
            if (classes == null || classes.Count == 0)
            {
                cell.Paragraphs[0].Append("No classes").Alignment = Xceed.Document.NET.Alignment.center;
                return;
            }

            cell.Paragraphs[0].Append(string.Join("\n\n", classes)).Alignment = Xceed.Document.NET.Alignment.left;
        }
    }
}
