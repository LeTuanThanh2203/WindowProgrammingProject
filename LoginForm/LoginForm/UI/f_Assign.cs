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
    public partial class f_Assign : Form
    {
        private HR hr = new HR();
        private Assign assign = new Assign();
        private PaginationHelper _pager;
        private DataTable dtAssign;
        public f_Assign()
        {
            InitializeComponent();
        }
        private void f_Assign_Load(object sender, EventArgs e)
        {
            _pager = new PaginationHelper(
                pageTable =>
                {
                    dgvAssign.DataSource = pageTable;
                    UIStyleHelper.StyleDataGridView(dgvAssign);
                },
                lblPageInfo,
                lblTotal,
                btnFirst,
                btnPrev,
                btnNext,
                btnLast,
                cboPageSize
            );

            LoadHRCombo();
            LoadCourseCombo();

            LoadData();
        }

        private void LoadHRCombo()
        {
            cboHR.DataSource = hr.GetHRsForCombo();

            cboHR.DisplayMember = "HRDisplay";
            cboHR.ValueMember = "ID";
        }

        private void LoadCourseCombo()
        {
            cboCourse.DataSource =
                assign.GetCoursesForCombo();

            cboCourse.DisplayMember =
                "CourseName";

            cboCourse.ValueMember =
                "CourseID";
        }
        private void LoadData()
        {
            try
            {
                _pager.SetData(assign.GetAssignList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAssign_Click(
    object sender,
    EventArgs e)
        {

            if (cboHR.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn HR hợp lệ.");
                cboHR.Focus();
                return;
            }

            if (cboCourse.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn môn học hợp lệ.");
                cboCourse.Focus();
                return;
            }
            string hrid =
                cboHR.SelectedValue.ToString();

            string courseid =
                cboCourse.SelectedValue.ToString();

            if (assign.CountAssignedCourses(hrid) >= 5)
            {
                MessageBox.Show(
                    "HR đã đạt tối đa 5 môn.");

                return;
            }

            if (assign.IsAssigned(
                    hrid,
                    courseid))
            {
                MessageBox.Show(
                    "Môn học đã được phân công.");

                return;
            }

            if (assign.InsertAssign(
                    hrid,
                    courseid))
            {
                MessageBox.Show(
                    "Phân công thành công.");

                LoadData();
            }
            else
            {
                MessageBox.Show(
                    "Phân công thất bại.");
            }


         
        }


        private void btnDelete_Click(
    object sender,
    EventArgs e)
        {
            if (dgvAssign.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn phân công.");

                return;
            }

            string hrid =
                dgvAssign.CurrentRow
                         .Cells["ID"]
                         .Value
                         .ToString();

            string courseid =
                dgvAssign.CurrentRow
                         .Cells["CourseID"]
                         .Value
                         .ToString();

            if (assign.DeleteAssign(
                    hrid,
                    courseid))
            {
                MessageBox.Show(
                    "Xóa thành công.");

                LoadData();
            }
            else
            {
                MessageBox.Show(
                    "Xóa thất bại.");
            }
        }

        private void txtSearchHR_TextChanged(
    object sender,
    EventArgs e)
        {
            string keyword =
                txtSearchHR.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadHRCombo();
                return;
            }

            cboHR.DataSource =
                assign.SearchHRForCombo(keyword);

            cboHR.DisplayMember =
                "HRDisplay";

            cboHR.ValueMember =
                "ID";
        }


        private void txtSearchCourse_TextChanged(
    object sender,
    EventArgs e)
        {
            string keyword =
                txtSearchCourse.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadCourseCombo();
                return;
            }

            cboCourse.DataSource =
                assign.SearchCourseForCombo(keyword);

            cboCourse.DisplayMember =
                "CourseName";

            cboCourse.ValueMember =
                "CourseID";
        }




    }



}
