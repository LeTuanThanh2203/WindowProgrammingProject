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

            cboHR_Gender.Items.Clear();
            cboHR_Gender.Items.Add("Male");
            cboHR_Gender.Items.Add("Female");
            if (cboHR_Gender.Items.Count > 0)
                cboHR_Gender.SelectedIndex = 0;

            LoadHRCombo();
            LoadCourseCombo();

            LoadData();

            cboHR.SelectedIndexChanged += cboHR_SelectedIndexChanged;
        }

        private void cboHR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHR.SelectedValue == null) return;
            if (cboHR.SelectedValue is DataRowView || cboHR.SelectedIndex < 0) return;

            string selectedId = cboHR.SelectedValue.ToString();
            LoadHRToFields(selectedId);
        }

        private void LoadHRToFields(string id)
        {
            if (string.IsNullOrEmpty(id)) return;
            HR selectedHr = hr.GetHRByID(id);
            if (selectedHr != null)
            {
                txtHR_ID.Text = selectedHr.ID;
                txtHR_ID.Enabled = false;
                txtHR_FirstName.Text = selectedHr.FirstName;
                txtHR_LastName.Text = selectedHr.LastName;
                if (selectedHr.Dob != DateTime.MinValue)
                {
                    dtpHR_Dob.Value = selectedHr.Dob;
                }
                else
                {
                    dtpHR_Dob.Value = DateTime.Now;
                }

                cboHR_Gender.SelectedItem = selectedHr.Gender;
                txtHR_Phone.Text = selectedHr.Phone;
                txtHR_Email.Text = selectedHr.Email;
                txtHR_Address.Text = selectedHr.Address;

                if (selectedHr.Picture != null && selectedHr.Picture.Length > 0)
                {
                    try
                    {
                        using (var ms = new System.IO.MemoryStream(selectedHr.Picture))
                        {
                            picHR_Photo.Image = Image.FromStream(ms);
                        }
                    }
                    catch
                    {
                        picHR_Photo.Image = null;
                    }
                }
                else
                {
                    picHR_Photo.Image = null;
                }
            }
        }

        private byte[] ImageToByteArray(Image img)
        {
            if (img == null) return null;
            try
            {
                using (var ms = new System.IO.MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            catch
            {
                return null;
            }
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

        private void btnHR_Upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picHR_Photo.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnHR_Add_Click(object sender, EventArgs e)
        {
            string id = txtHR_ID.Text.Trim();
            string fname = txtHR_FirstName.Text.Trim();
            string lname = txtHR_LastName.Text.Trim();
            DateTime dob = dtpHR_Dob.Value;
            string gender = cboHR_Gender.SelectedItem?.ToString();
            string phone = txtHR_Phone.Text.Trim();
            string email = txtHR_Email.Text.Trim();
            string address = txtHR_Address.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng nhập ID HR.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHR_ID.Focus();
                return;
            }
            if (string.IsNullOrEmpty(fname))
            {
                MessageBox.Show("Vui lòng nhập First Name.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHR_FirstName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(lname))
            {
                MessageBox.Show("Vui lòng nhập Last Name.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHR_LastName.Focus();
                return;
            }

            if (hr.GetHRByID(id) != null)
            {
                MessageBox.Show("ID HR đã tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHR_ID.Focus();
                return;
            }

            byte[] photoBytes = null;
            if (picHR_Photo.Image != null)
            {
                photoBytes = ImageToByteArray(picHR_Photo.Image);
            }

            HR newHr = new HR(id, fname, lname, dob, gender, phone, email, address, photoBytes);
            if (newHr.AddHR())
            {
                MessageBox.Show("Thêm HR thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHRCombo();
                btnHR_Clear_Click(null, null);
            }
            else
            {
                MessageBox.Show("Thêm HR thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHR_Edit_Click(object sender, EventArgs e)
        {
            string id = txtHR_ID.Text.Trim();
            string fname = txtHR_FirstName.Text.Trim();
            string lname = txtHR_LastName.Text.Trim();
            DateTime dob = dtpHR_Dob.Value;
            string gender = cboHR_Gender.SelectedItem?.ToString();
            string phone = txtHR_Phone.Text.Trim();
            string email = txtHR_Email.Text.Trim();
            string address = txtHR_Address.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập ID HR cần chỉnh sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(fname))
            {
                MessageBox.Show("Vui lòng nhập First Name.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHR_FirstName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(lname))
            {
                MessageBox.Show("Vui lòng nhập Last Name.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHR_LastName.Focus();
                return;
            }

            if (hr.GetHRByID(id) == null)
            {
                MessageBox.Show("Không tìm thấy HR với ID này để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] photoBytes = null;
            if (picHR_Photo.Image != null)
            {
                photoBytes = ImageToByteArray(picHR_Photo.Image);
            }

            HR updatedHr = new HR(id, fname, lname, dob, gender, phone, email, address, photoBytes);
            if (updatedHr.EditHR())
            {
                MessageBox.Show("Cập nhật HR thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHRCombo();
            }
            else
            {
                MessageBox.Show("Cập nhật HR thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHR_Delete_Click(object sender, EventArgs e)
        {
            string id = txtHR_ID.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập ID HR cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (hr.GetHRByID(id) == null)
            {
                MessageBox.Show("Không tìm thấy HR với ID này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa HR với ID {id}?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                if (HR.DeleteHR(id))
                {
                    MessageBox.Show("Xóa HR thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHRCombo();
                    btnHR_Clear_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Xóa HR thất bại (HR có thể đang được phân công).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHR_Clear_Click(object sender, EventArgs e)
        {
            txtHR_ID.Text = "";
            txtHR_ID.Enabled = true;
            txtHR_FirstName.Text = "";
            txtHR_LastName.Text = "";
            dtpHR_Dob.Value = DateTime.Now;
            if (cboHR_Gender.Items.Count > 0) cboHR_Gender.SelectedIndex = 0;
            txtHR_Phone.Text = "";
            txtHR_Email.Text = "";
            txtHR_Address.Text = "";
            picHR_Photo.Image = null;
        }

        private void dgvAssign_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAssign.CurrentRow == null) return;

            try
            {
                if (dgvAssign.CurrentRow.Cells["ID"].Value != null)
                {
                    string hrId = dgvAssign.CurrentRow.Cells["ID"].Value.ToString();
                    LoadHRToFields(hrId);

                    cboHR.SelectedValue = hrId;
                }
            }
            catch
            {
            }
        }
    }
}
