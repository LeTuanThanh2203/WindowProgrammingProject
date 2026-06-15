using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection.Metadata;
using System.Windows.Forms;

namespace Project_Group6
{
    public partial class f_ScoreView : Form
    {
        My_DB db = new My_DB();
        private string _mssv;
        Score score = new Score();

        public f_ScoreView(string mssv)
        {
            InitializeComponent();
            _mssv = mssv;
            this.Load += f_Score_Load;
            dgvScore.CellClick += dgvScore_CellClick;
        }

        private void f_Score_Load(object sender, EventArgs e)
        {
            LoadStudentInfo();
            LoadScores();
        }

        // =========================
        // LOAD STUDENT INFO
        // =========================
        private void LoadStudentInfo()
        {
            // Dùng GetStudentByID — connection riêng, không conflict
            Student student = new Student().GetStudentByID(_mssv);
            if (student == null) return;

            lblID.Text = student.MSSV;
            lblFirstname.Text = student.Fname;
            lblLastname.Text = student.Lname;
            lblDob.Text = student.Dob.ToString("dd/MM/yyyy");
            lblGender.Text = student.Gender;
            lblPhone.Text = student.Phone;
            lblAddress.Text = student.Address;
            lblEmail.Text = student.Email;

            // Hiện ảnh — copy y chang f_ListStudent
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

        // =========================
        // LOAD SCORE
        // =========================
        private void LoadScores()
        {
            dgvScore.DataSource = score.GetScoreByStudent(_mssv);

            dgvScore.AllowUserToAddRows = false;
            dgvScore.ReadOnly = true;
            dgvScore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // dgvScore_CellClick — KHÔNG CẦN SỬA
        // LoadStudentInfo() — KHÔNG CẦN SỬA



        // =========================
        // CLICK SCORE ROW
        // =========================
        private void dgvScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvScore.Rows[e.RowIndex];
            string ov = row.Cells["Overview"].Value?.ToString();

            lblOverview.Text = "Overview: " + ov;
            lblOverview.ForeColor = ov switch
            {
                "Excellent" => Color.Blue,
                "Good" => Color.Green,
                "Pass" => Color.DarkOrange,
                _ => Color.Red
            };
        }
    }
}