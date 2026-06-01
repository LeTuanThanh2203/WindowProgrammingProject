using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LoginForm;
using ProjectMonHoc;
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
        private readonly string currentMSSV = Globals.Username;

        public f_StudentInformation()
        {
            InitializeComponent();
            LoadStudentInfo();
            LoadFilters();

            // Gắn event SAU LoadFilters để tránh trigger khi đang load
            cboAcademicYear.SelectedIndexChanged += Filter_Changed;
            cboSemester.SelectedIndexChanged += Filter_Changed;

            // Ẩn chart sau khi gắn event
            chartScore.Visible = false;
        }

        // ================= THÔNG TIN SINH VIÊN =================
        private void LoadStudentInfo()
        {
            Student student = new Student().GetStudentByID(currentMSSV);
            if (student == null) return;

            lblID.Text = student.MSSV;
            lblFirstname.Text = student.Fname;
            lblLastname.Text = student.Lname;
            lblDob.Text = student.Dob.ToString("dd/MM/yyyy");
            lblGender.Text = student.Gender;
            lblPhone.Text = student.Phone;
            lblAddress.Text = student.Address;
            lblEmail.Text = student.Email;

            if (student.Picture != null && student.Picture.Length > 0)
            {
                MemoryStream ms = new MemoryStream(student.Picture);
                picStudent.Image = Image.FromStream(ms);
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
            Student student = new Student();
            DataTable dt = student.GetAcademicYearsByMSSV(currentMSSV);

            cboAcademicYear.Items.Clear();
            cboAcademicYear.Items.Add("-- Select Year --");
            foreach (DataRow row in dt.Rows)
                cboAcademicYear.Items.Add(row["AcademicYear"].ToString());
            cboAcademicYear.SelectedIndex = 0;

            cboSemester.Items.Clear();
            cboSemester.Items.Add("-- Select Semester --");
            cboSemester.Items.Add("Semester 1");
            cboSemester.Items.Add("Semester 2");
            cboSemester.Items.Add("Summer");
            cboSemester.SelectedIndex = 0;

            // Ẩn chart khi mới mở form
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

            string sem = cboSemester.SelectedItem.ToString();
            int semesterValue;
            if (sem.Contains("1")) semesterValue = 1;
            else if (sem.Contains("2")) semesterValue = 2;
            else semesterValue = 3;

            Score score = new Score();
            DataTable dt = score.GetScoreByFilter(currentMSSV, selectedYear, semesterValue.ToString());

            // Không có data → ẩn chart hẳn
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
                    ? 0
                    : Convert.ToDouble(row["TotalScore"]);
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
        new Axis { Labels = courseNames, LabelsRotation = -25, TextSize = 11, Name = "Course" }
    };

            chartScore.YAxes = new[]
            {
        new Axis { MinLimit = 0, MaxLimit = 10, Name = "Score" }
    };

            // Có data → hiện chart
            chartScore.Visible = true;
        }

    }
}