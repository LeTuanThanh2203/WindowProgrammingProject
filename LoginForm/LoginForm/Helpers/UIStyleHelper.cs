using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    public static class UIStyleHelper
    {
        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = true;
            dgv.AllowUserToResizeRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 36;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.GridColor = Color.FromArgb(230, 232, 236);

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5F);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(10, 61, 120);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(10, 61, 120);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(246, 249, 253);
        }
    }
}
