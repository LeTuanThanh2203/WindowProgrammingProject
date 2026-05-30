using Project_Group6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_AddScore : Form
    {
        Student student =
                new Student();
        public f_AddScore()
        {
            InitializeComponent();
         
        }

        // ================= LOAD =================
        private void
            f_AddScore_Load(
            object sender,
            EventArgs e)
        {
            dgvStudent.DataSource =
                student.GetStudentsRegisteredCourse();
        }

        // ================= CLICK ROW =================
        private void
            dgvStudent_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            txtMSSV.Text =
                dgvStudent.Rows[e.RowIndex]
                .Cells["MSSV"]
                .Value
                .ToString();

            DataTable table =
                student.GetCoursesWithoutScore(
                    txtMSSV.Text);

            cboCourse.DataSource =
                table;

            cboCourse.DisplayMember =
                "CourseName";

            cboCourse.ValueMember =
                "CourseID";
        }

        // ================= TINH DIEM =================
        private void CalculateScore()
        {
            if (txtQT.Text == ""
                || txtCK.Text == "")
            {
                txtTK.Text = "";
                return;
            }

            decimal qt =
                Convert.ToDecimal(
                    txtQT.Text);

            decimal ck =
                Convert.ToDecimal(
                    txtCK.Text);

            decimal total =
                (qt + ck) / 2;

            txtTK.Text =
                total.ToString("0.00");
        }

        // ================= VALIDATE =================
        private bool Verify()
        {
            return
                txtMSSV.Text != ""
                && txtQT.Text != ""
                && txtCK.Text != "";
        }

        // ================= QT =================
        private void
            txtQT_TextChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                if (txtQT.Text == "")
                {
                    return;
                }

                decimal qt =
                    Convert.ToDecimal(
                        txtQT.Text);

                if (qt < 0 || qt > 10)
                {
                    MessageBox.Show(
                        "Score must be 0 -> 10");

                    txtQT.Clear();

                    return;
                }

                CalculateScore();
            }
            catch
            {
                txtQT.Clear();
            }
        }

        // ================= CK =================
        private void
            txtCK_TextChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                if (txtCK.Text == "")
                {
                    return;
                }

                decimal ck =
                    Convert.ToDecimal(
                        txtCK.Text);

                if (ck < 0 || ck > 10)
                {
                    MessageBox.Show(
                        "Score must be 0 -> 10");

                    txtCK.Clear();

                    return;
                }

                CalculateScore();
            }
            catch
            {
                txtCK.Clear();
            }
        }

        // ================= ADD =================
        private void
            btnAdd_Click(
            object sender,
            EventArgs e)
        {
            if (!Verify())
            {
                MessageBox.Show(
                    "Please input score");

                return;
            }

            Score score =
                new Score();

            score.MSSV =
                txtMSSV.Text;

            score.CourseID =
                Convert.ToInt32(
                    cboCourse.SelectedValue);

            score.MidtermScore =
                Convert.ToDecimal(
                    txtQT.Text);

            score.FinalScore =
                Convert.ToDecimal(
                    txtCK.Text);

            score.TotalScore =
                Convert.ToDecimal(
                    txtTK.Text);

            score.Overview =
                score.GetOverview();

            bool success =
                score.AddScore();

            if (success)
            {
                MessageBox.Show(
                    "Add score success");

                DataTable table =
                    student.GetCoursesWithoutScore(
                        txtMSSV.Text);

                cboCourse.DataSource =
                    table;
            }
            else
            {
                MessageBox.Show(
                    "Add score failed");
            }
        }


    }
}
