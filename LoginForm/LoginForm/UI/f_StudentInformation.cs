using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LoginForm;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Project_Group6
{
    public partial class f_StudentInformation : Form
    {
        // Schema mới: currentID thay currentMSSV
        private readonly string currentID = Globals.Username;

        public f_StudentInformation()
        {
            InitializeComponent();
            LoadStudentInfo();
            LoadFilters();

            cboAcademicYear.SelectedIndexChanged += Filter_Changed;
            cboSemester.SelectedIndexChanged += Filter_Changed;

            chartScore.Visible = false;
        }

        // ================= THÔNG TIN SINH VIÊN =================
        private void LoadStudentInfo()
        {
            // Schema mới: GetStudentByID nhận ID
            Student student = new Student().GetStudentByID(currentID);
            if (student == null) return;

            // Schema mới: ID, FirstName, LastName, Address (không có Hometown)
            lblID.Text = student.ID;
            lblFirstname.Text = student.FirstName;
            lblLastname.Text = student.LastName;
            lblDob.Text = student.Dob.ToString("dd/MM/yyyy");
            lblGender.Text = student.Gender;
            lblPhone.Text = student.Phone;
            lblAddress.Text = student.Address;
            lblEmail.Text = student.Email;

            if (student.Picture != null && student.Picture.Length > 0)
            {
                picStudent.Image = Image.FromStream(new MemoryStream(student.Picture));
                picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                picStudent.Image = null;
            }
        }

        // ================= LOAD COMBOBOX =================
        private void LoadFilters()
        {
            // Schema mới: AcademicYear lấy từ bảng Class (DKMH không còn cột AcademicYear)
            // Dùng GetDistinctAcademicYears() từ Class model
            var dt = new Class().GetDistinctAcademicYears();

            cboAcademicYear.Items.Clear();
            cboAcademicYear.Items.Add("-- Select Year --");
            foreach (DataRow row in dt.Rows)
                cboAcademicYear.Items.Add(row[0].ToString());
            cboAcademicYear.SelectedIndex = 0;

            // Schema mới: Semester là NVARCHAR(20)
            cboSemester.Items.Clear();
            cboSemester.Items.Add("-- Select Semester --");
            cboSemester.Items.Add("HK1");
            cboSemester.Items.Add("HK2");
            cboSemester.Items.Add("Summer");
            cboSemester.SelectedIndex = 0;

            chartScore.Series = Array.Empty<ISeries>();
        }

        // ================= FILTER CHANGED =================
        private void Filter_Changed(object sender, EventArgs e)
        {
            bool yearSelected = cboAcademicYear.SelectedIndex > 0;
            bool semesterSelected = cboSemester.SelectedIndex > 0;

            if (yearSelected && semesterSelected)
            {
                chartScore.Visible = true;
                LoadChart();
            }
            else
            {
                chartScore.Visible = false;
                chartScore.Series = Array.Empty<ISeries>();
            }
        }

        // ================= BIỂU ĐỒ ĐIỂM =================
        private void LoadChart()
        {
            string selectedYear = cboAcademicYear.SelectedItem.ToString();
            // Schema mới: Semester là string (HK1/HK2/Summer)
            string semester = cboSemester.SelectedItem.ToString();

            Score score = new Score();
            // GetScoreByFilter nhận (id, academicYear, semester string)
            DataTable dt = score.GetScoreByFilter(currentID, selectedYear, semester);

            if (dt == null || dt.Rows.Count == 0)
            {
                chartScore.Visible = false;
                return;
            }

            var courseNames = new List<string>();
            var totalVals = new List<double>();

            foreach (DataRow row in dt.Rows)
            {
                courseNames.Add(row["CourseName"].ToString());
                double total = row["TotalScore"] == DBNull.Value
                    ? 0 : Convert.ToDouble(row["TotalScore"]);
                totalVals.Add(total);
            }

            chartScore.Series = new ISeries[]
            {
                new ColumnSeries<double>
                {
                    Name   = "Total Score",
                    Values = totalVals,
                    Fill   = new SolidColorPaint(SKColors.SteelBlue)
                }
            };

            chartScore.XAxes = new[]
            {
                new Axis
                {
                    Labels          = courseNames,
                    LabelsRotation  = -25,
                    TextSize        = 11,
                    Name            = "Course"
                }
            };

            chartScore.YAxes = new[]
            {
                new Axis { MinLimit = 0, MaxLimit = 10, Name = "Score" }
            };

            chartScore.Visible = true;
        }
    }
}