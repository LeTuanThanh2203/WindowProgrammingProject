using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView.Painting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_Dashboard : Form
    {
        public f_Dashboard()
        {
            InitializeComponent();
            UIStyleHelper.StyleDataGridView(dgvTopStudents);
            SetupCardHoverEvents();
            LoadDashboard();
        }

        private void SetupCardHoverEvents()
        {
            SetupCardHover(pnTotalStudents, Color.FromArgb(41, 128, 185), Color.FromArgb(52, 152, 219));
            SetupCardHover(pnTotalCourses, Color.FromArgb(142, 68, 173), Color.FromArgb(155, 89, 182));
            SetupCardHover(pnTotalClasses, Color.FromArgb(39, 174, 96), Color.FromArgb(46, 204, 113));
            SetupCardHover(pnTotalEnrollments, Color.FromArgb(211, 84, 0), Color.FromArgb(230, 126, 34));
        }

        private void SetupCardHover(Panel cardPanel, Color normalColor, Color hoverColor)
        {
            cardPanel.MouseEnter += (s, e) => cardPanel.BackColor = hoverColor;
            cardPanel.MouseLeave += (s, e) => cardPanel.BackColor = normalColor;
            foreach (Control ctrl in cardPanel.Controls)
            {
                ctrl.MouseEnter += (s, e) => cardPanel.BackColor = hoverColor;
                ctrl.MouseLeave += (s, e) => cardPanel.BackColor = normalColor;
            }
        }

        private void LoadDashboard()
        {
            LoadStatistics();
            LoadGenderChart();
            LoadEnrollmentChart();
            LoadGradeChart();
            LoadTopStudents();
        }

        // ================= STATISTICS CARDS =================
        private void LoadStatistics()
        {
            Student student = new Student();

            int totalStudents = student.TotalStudents();
            int totalCourses = student.TotalCoursesCount();
            int totalClasses = student.TotalClassesCount();
            int totalEnrollments = student.TotalEnrollmentsCount();

            lblTotalStudents.Text = totalStudents.ToString();
            lblTotalCourses.Text = totalCourses.ToString();
            lblTotalClasses.Text = totalClasses.ToString();
            lblTotalEnrollments.Text = totalEnrollments.ToString();
        }

        // ================= GENDER DISTRIBUTION CHART =================
        private void LoadGenderChart()
        {
            Student student = new Student();

            double maleStudents = student.TotalMaleStudents();
            double femaleStudents = student.TotalFemaleStudents();

            var chart = new PieChart
            {
                Dock = DockStyle.Fill,
                Series = new ISeries[]
                {
                    new PieSeries<double> 
                    { 
                        Values = new[] { maleStudents }, 
                        Name = "Male",
                        Fill = new SolidColorPaint(new SkiaSharp.SKColor(41, 128, 185))
                    },
                    new PieSeries<double> 
                    { 
                        Values = new[] { femaleStudents }, 
                        Name = "Female",
                        Fill = new SolidColorPaint(new SkiaSharp.SKColor(231, 76, 60))
                    }
                }
            };

            pnStudentChart.Controls.Clear();
            pnStudentChart.Controls.Add(chart);
        }

        // ================= ENROLLMENT CHART BY YEAR =================
        private void LoadEnrollmentChart()
        {
            Student student = new Student();
            DataTable table = student.GetStudentStatisticsByYear();

            var values = new List<int>();
            var labels = new List<string>();

            foreach (DataRow row in table.Rows)
            {
                labels.Add(row["EnrollmentYear"].ToString());
                values.Add(Convert.ToInt32(row["TotalStudents"]));
            }

            var chart = new CartesianChart
            {
                Dock = DockStyle.Fill,
                Series = new ISeries[]
                {
                    new ColumnSeries<int>
                    {
                        Values = values.ToArray(),
                        Name   = "Students",
                        Fill = new SolidColorPaint(new SkiaSharp.SKColor(46, 204, 113))
                    }
                },
                XAxes = new[]
                {
                    new Axis { Labels = labels.ToArray(), Name = "Enrollment Year" }
                },
                YAxes = new[]
                {
                    new Axis { Name = "Students" }
                }
            };

            pnEnrollmentChart.Controls.Clear();
            pnEnrollmentChart.Controls.Add(chart);
        }

        // ================= ACADEMIC PERFORMANCE (GRADE DISTRIBUTION) =================
        private void LoadGradeChart()
        {
            Student student = new Student();
            DataTable table = student.GetGradeDistribution();

            var seriesList = new List<ISeries>();

            // Define harmonious colors for performance categories
            // Excellent: Gold, Good: Light Blue, Pass: Green, Fail: Red
            var colorMap = new Dictionary<string, SkiaSharp.SKColor>
            {
                { "Excellent", new SkiaSharp.SKColor(241, 196, 15) },
                { "Good",      new SkiaSharp.SKColor(52, 152, 219) },
                { "Pass",      new SkiaSharp.SKColor(46, 204, 113) },
                { "Fail",      new SkiaSharp.SKColor(231, 76, 60) }
            };

            foreach (DataRow row in table.Rows)
            {
                string overview = row["Overview"].ToString();
                double count = Convert.ToDouble(row["Total"]);

                SkiaSharp.SKColor fillColor = colorMap.ContainsKey(overview) 
                    ? colorMap[overview] 
                    : new SkiaSharp.SKColor(149, 165, 166); // Default Gray

                seriesList.Add(new PieSeries<double>
                {
                    Values = new[] { count },
                    Name = overview,
                    Fill = new SolidColorPaint(fillColor)
                });
            }

            var chart = new PieChart
            {
                Dock = DockStyle.Fill,
                Series = seriesList.ToArray()
            };

            pnGradeChart.Controls.Clear();
            pnGradeChart.Controls.Add(chart);
        }

        // ================= TOP 5 STUDENTS =================
        private void LoadTopStudents()
        {
            Student student = new Student();
            DataTable table = student.GetTopStudentsByGPA();

            dgvTopStudents.DataSource = table;

            if (dgvTopStudents.Columns["ID"] != null)
                dgvTopStudents.Columns["ID"].HeaderText = "Student ID";
            if (dgvTopStudents.Columns["StudentName"] != null)
                dgvTopStudents.Columns["StudentName"].HeaderText = "Full Name";
            if (dgvTopStudents.Columns["GPA"] != null)
            {
                dgvTopStudents.Columns["GPA"].HeaderText = "GPA";
                dgvTopStudents.Columns["GPA"].DefaultCellStyle.Format = "0.00";
            }
        }
    }
}