using Project_Group6.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_AddCourse : Form
    {
        private readonly Course _course = new();

        public f_AddCourse()
        {
            InitializeComponent();
            this.Load += f_AddCourse_Load;
            btn_AddCourse.Click += btn_AddCourse_Click;
            btnClear.Click += btnClear_Click;
            bt_Cancel.Click += bt_Cancel_Click;
        }

        // ================= LOAD =================
        private void f_AddCourse_Load(object sender, EventArgs e)
        {
            LoadPrerequisiteCombo();
        }

        // ================= LOAD PREREQUISITE COMBO =================
        private void LoadPrerequisiteCombo()
        {
            DataTable dt = _course.GetCoursesForCombo();

            // Thêm dòng "-- None --" đầu tiên
            DataRow none = dt.NewRow();
            none["CourseID"] = DBNull.Value;
            none["CourseDisplay"] = "-- None --";
            dt.Rows.InsertAt(none, 0);

            cbo_Prerequisite.DataSource = dt;
            cbo_Prerequisite.DisplayMember = "CourseDisplay";
            cbo_Prerequisite.ValueMember = "CourseID";
            cbo_Prerequisite.SelectedIndex = 0;
        }

        // ================= ADD =================
        private void btn_AddCourse_Click(object sender, EventArgs e)
        {
            // --- Validate CourseID ---
            if (string.IsNullOrWhiteSpace(txt_CourseID.Text))
            {
                MessageBox.Show("Please enter Course ID!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_CourseID.Focus();
                return;
            }

            // --- Validate CourseName ---
            if (string.IsNullOrWhiteSpace(txt_NameCourse.Text))
            {
                MessageBox.Show("Please enter Course Name!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_NameCourse.Focus();
                return;
            }

            // --- Validate Credits ---
            if (!int.TryParse(txt_Credits.Text, out int credits) || credits <= 0)
            {
                MessageBox.Show("Credits must be a positive number!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Credits.Focus();
                return;
            }

            // --- Period fields (optional, default 0) ---
            int.TryParse(txt_TotalPeriods.Text, out int total);
            int.TryParse(txt_TheoryPeriods.Text, out int theory);
            int.TryParse(txt_PracticePeriods.Text, out int practice);

            // --- Validate periods nếu người dùng nhập ---
            if ((total > 0 || theory > 0 || practice > 0)
             && theory + practice != total && total > 0)
            {
                MessageBox.Show(
                    "Theory + Practice periods must equal Total periods!",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TheoryPeriods.Focus();
                return;
            }

            // --- Prerequisite (nullable string) ---
            string prereqID = null;
            if (cbo_Prerequisite.SelectedValue != null
             && cbo_Prerequisite.SelectedValue != DBNull.Value)
            {
                string val = cbo_Prerequisite.SelectedValue.ToString().Trim();
                if (!string.IsNullOrEmpty(val)) prereqID = val;
            }

            var course = new Course
            {
                CourseID = txt_CourseID.Text.Trim().ToUpper(),
                CourseName = txt_NameCourse.Text.Trim(),
                Credits = credits,
                TotalPeriods = total,
                TheoryPeriods = theory,
                PracticePeriods = practice,
                PrerequisiteID = prereqID,
                IsRequired = chk_IsRequired.Checked,
                Description = string.IsNullOrWhiteSpace(txt_Description.Text)
                                      ? null
                                      : txt_Description.Text.Trim()
            };

            bool ok = course.AddCourse();

            MessageBox.Show(
                ok ? "Course added successfully!" : "Failed to add course.\nCourse ID may already exist.",
                "Add Course",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (ok)
            {
                ClearForm();
                this.Close();
            }
        }

        // ================= CLEAR =================
        private void btnClear_Click(object sender, EventArgs e) => ClearForm();

        private void ClearForm()
        {
            txt_CourseID.Clear();
            txt_NameCourse.Clear();
            txt_Credits.Clear();
            txt_TotalPeriods.Clear();
            txt_TheoryPeriods.Clear();
            txt_PracticePeriods.Clear();
            txt_Description.Clear();
            chk_IsRequired.Checked = false;
            cbo_Prerequisite.SelectedIndex = 0;
            txt_CourseID.Focus();
        }

        private void bt_Cancel_Click(object sender, EventArgs e) => this.Close();
    }
}