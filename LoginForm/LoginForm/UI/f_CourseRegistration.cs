using LoginForm;
using Project_Group6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_CourseRegistration : Form
    {
        Student student =
            new Student();

        // MSSV hiện tại
        string currentMSSV =
            Globals.Username;

        public f_CourseRegistration()
        {
            InitializeComponent();

            Load +=
                f_CourseRegistration_Load;

            btnSelectedRegist.Click +=
                btnSelectedRegist_Click;

            btnSelectedUnRegist.Click +=
                btnSelectedUnRegist_Click;

            btnSelectedALLRegist.Click +=
                btnSelectedALLRegist_Click;

            btnSelectedALLUnRegist.Click +=
                btnSelectedALLUnRegist_Click;
        }

        private void
            f_CourseRegistration_Load(
            object sender,
            EventArgs e)
        {
            LoadCourse();
        }

        // LOAD DATA
        private void LoadCourse()
        {
            dgvUnRegistereCourse.DataSource =
                student.GetUnRegisteredCourses(
                    currentMSSV);

            dgvRegistereCourse.DataSource =
                student.GetRegisteredCourses(
                    currentMSSV);

            dgvUnRegistereCourse.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvRegistereCourse.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        // REGISTER 1 COURSE
        private void
            btnSelectedRegist_Click(
            object sender,
            EventArgs e)
        {
            if (dgvUnRegistereCourse.CurrentRow
                == null)
            {
                return;
            }

            int courseID =
                Convert.ToInt32(
                    dgvUnRegistereCourse
                    .CurrentRow
                    .Cells["CourseID"]
                    .Value);

            var result =
                Student.RegisterCourse(
                    currentMSSV,
                    courseID);

            MessageBox.Show(
                result.message);

            if (result.success)
            {
                LoadCourse();
            }
        }

        // CANCEL 1 COURSE
        private void
            btnSelectedUnRegist_Click(
            object sender,
            EventArgs e)
        {
            if (dgvRegistereCourse.CurrentRow
                == null)
            {
                return;
            }

            int courseID =
                Convert.ToInt32(
                    dgvRegistereCourse
                    .CurrentRow
                    .Cells["CourseID"]
                    .Value);

            var result =
                Student.CancelCourse(
                    currentMSSV,
                    courseID);

            MessageBox.Show(
                result.message);

            if (result.success)
            {
                LoadCourse();
            }
        }

        // REGISTER ALL
        private void
            btnSelectedALLRegist_Click(
            object sender,
            EventArgs e)
        {
            foreach (DataGridViewRow row
                in dgvUnRegistereCourse.Rows)
            {
                if (row.Cells["CourseID"]
                    .Value != null)
                {
                    int courseID =
                        Convert.ToInt32(
                            row.Cells["CourseID"]
                            .Value);

                    Student.RegisterCourse(
                        currentMSSV,
                        courseID);
                }
            }

            LoadCourse();

            MessageBox.Show(
                "Registered all courses!");
        }

        // CANCEL ALL
        private void
            btnSelectedALLUnRegist_Click(
            object sender,
            EventArgs e)
        {
            foreach (DataGridViewRow row
                in dgvRegistereCourse.Rows)
            {
                if (row.Cells["CourseID"]
                    .Value != null)
                {
                    int courseID =
                        Convert.ToInt32(
                            row.Cells["CourseID"]
                            .Value);

                    Student.CancelCourse(
                        currentMSSV,
                        courseID);
                }
            }

            LoadCourse();

            MessageBox.Show(
                "Cancelled all courses!");
        }
    }
}
