using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
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
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            LoadStatistics();
            LoadGenderChart();
            LoadEnrollmentChart();
        }

        // ================= STATISTICS =================
        private void LoadStatistics()
        {
            Student student = new Student();

            // Schema mới: TotalStudents/TotalMaleStudents/TotalFemaleStudents (int)
            // Không còn totalOtherStudent() — schema chỉ có Male/Female
            int totalStudents = student.TotalStudents();
            int maleStudents = student.TotalMaleStudents();
            int femaleStudents = student.TotalFemaleStudents();

            double malePercent = totalStudents > 0 ? maleStudents * 100.0 / totalStudents : 0;
            double femalePercent = totalStudents > 0 ? femaleStudents * 100.0 / totalStudents : 0;

            lblTotalStudents.Text = totalStudents.ToString();
            lblMalePercent.Text = malePercent.ToString("0.0") + "%";
            lblFemalePercent.Text = femalePercent.ToString("0.0") + "%";

            // Nếu vẫn còn label "Other" trên form, ẩn hoặc xoá đi
            if (lblOtherPercent != null)
                lblOtherPercent.Visible = false;
            if (pnOtherStudents != null)
                pnOtherStudents.Visible = false;
        }

        // ================= GENDER CHART =================
        private void LoadGenderChart()
        {
            Student student = new Student();

            // Schema mới: chỉ Male và Female
            double maleStudents = student.TotalMaleStudents();
            double femaleStudents = student.TotalFemaleStudents();

            var chart = new PieChart
            {
                Dock = DockStyle.Fill,
                Series = new ISeries[]
                {
                    new PieSeries<double> { Values = new[] { maleStudents },   Name = "Male"   },
                    new PieSeries<double> { Values = new[] { femaleStudents }, Name = "Female" }
                }
            };

            pnStudentChart.Controls.Clear();
            pnStudentChart.Controls.Add(chart);
        }

        // ================= ENROLLMENT CHART =================
        private void LoadEnrollmentChart()
        {
            Student student = new Student();

            // GetStudentStatisticsByYear() dùng cột ID thay MSSV
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
                        Name   = "Students"
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

        // ================= HOVER EFFECTS =================
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            var panel = (sender as Control) is Panel p ? p : (Panel)((Control)sender).Parent;

            if (panel == pnTotalStudents) panel.BackColor = Color.FromArgb(93, 173, 226);
            else if (panel == pnMaleStudents) panel.BackColor = Color.FromArgb(88, 214, 141);
            else if (panel == pnFemaleStudents) panel.BackColor = Color.FromArgb(236, 112, 99);
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            var panel = (sender as Control) is Panel p ? p : (Panel)((Control)sender).Parent;

            if (panel == pnTotalStudents) panel.BackColor = Color.FromArgb(174, 214, 241);
            else if (panel == pnMaleStudents) panel.BackColor = Color.FromArgb(169, 223, 191);
            else if (panel == pnFemaleStudents) panel.BackColor = Color.FromArgb(245, 183, 177);
        }
    }
}