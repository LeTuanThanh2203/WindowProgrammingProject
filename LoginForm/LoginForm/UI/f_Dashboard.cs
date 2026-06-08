using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using Microsoft.Data.SqlClient;
using Project_Group6.Models;
using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Principal;
using System.Text;
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
      
        private void LoadStatistics()
        {
            Student student = new Student();

            double totalStudents = student.totalStudent();
            double maleStudents = student.totalMaleStudent();
            double femaleStudents = student.totalFemaleStudent();
            double otherStudents = student.totalOtherStudent();

            double malePercent =
                totalStudents > 0 ? maleStudents * 100.0 / totalStudents : 0;

            double femalePercent =
                totalStudents > 0 ? femaleStudents * 100.0 / totalStudents : 0;

            double otherPercent =
                totalStudents > 0 ? otherStudents * 100.0 / totalStudents : 0;

            lblTotalStudents.Text = totalStudents.ToString();

            lblMalePercent.Text = malePercent.ToString("0.0") + "%";
            lblFemalePercent.Text = femalePercent.ToString("0.0") + "%";
            lblOtherPercent.Text = otherPercent.ToString("0.0") + "%";
        }
        private void LoadGenderChart()
        {
            Student student = new Student();

       
            double maleStudents = student.totalMaleStudent();
            double femaleStudents = student.totalFemaleStudent();
            double otherStudents = student.totalOtherStudent();

            var chart = new PieChart
            {
                Dock = DockStyle.Fill,

                Series = new ISeries[]
                {
            new PieSeries<double>
            {
                Values = new[] { maleStudents },
                Name = "Male"
            },

            new PieSeries<double>
            {
                Values = new[] { femaleStudents },
                Name = "Female"
            },

            new PieSeries<double>
            {
                Values = new[] { otherStudents },
                Name = "Other"
            }
                }
            };

            pnStudentChart.Controls.Clear();
            pnStudentChart.Controls.Add(chart);
        }
        private void LoadEnrollmentChart()
        {
            Student student = new Student();

            DataTable table = student.GetStudentStatisticsByYear();

            List<int> values = new();
            List<string> labels = new();

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
                Name = "Students"
            }
                },

                XAxes = new[]
                {
            new Axis
            {
                Labels = labels.ToArray(),
                Name = "Enrollment Year"
            }
        },

                YAxes = new[]
                {
            new Axis
            {
                Name = "Students"
            }
        }
            };

            pnEnrollmentChart.Controls.Clear();
            pnEnrollmentChart.Controls.Add(chart);
        }
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            Panel panel = control as Panel ?? (Panel)control.Parent;


            if (panel == pnTotalStudents)
                panel.BackColor = Color.FromArgb(93, 173, 226);

            else if (panel == pnMaleStudents)
                panel.BackColor = Color.FromArgb(88, 214, 141);

            else if (panel == pnFemaleStudents)
                panel.BackColor = Color.FromArgb(236, 112, 99);

            else if (panel == pnOtherStudents)
                panel.BackColor = Color.FromArgb(187, 143, 206);
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            Panel panel = control as Panel ?? (Panel)control.Parent;

            if (panel == pnTotalStudents)
                panel.BackColor = Color.FromArgb(174, 214, 241);

            else if (panel == pnMaleStudents)
                panel.BackColor = Color.FromArgb(169, 223, 191);

            else if (panel == pnFemaleStudents)
                panel.BackColor = Color.FromArgb(245, 183, 177);

            else if (panel == pnOtherStudents)
                panel.BackColor = Color.FromArgb(215, 189, 226);
        }

    }
}
