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
            Student student =
                new Student();

            lblStudentTotal.Text =
                student.TotalStudent()
                .ToString();

            // TOTAL COURSE
            Course course =
                new Course();

            lblCourseTotal.Text =
                course.TotalCourse()
                .ToString();

            using (My_DB db = new My_DB())
            {
                SqlCommand command =
                    new SqlCommand(
                    @"SELECT COUNT(*)
              FROM DataLoginForm
              WHERE IsApproved = 0",
                    db.getConnection);

                db.openConnection();

                int total =
                    Convert.ToInt32(
                        command.ExecuteScalar());

                lblAccountTotal.Text =
                    total.ToString();
            }
        }
    }
}
