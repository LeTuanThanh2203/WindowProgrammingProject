using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    public static class UIStyleHelper
    {
        // ────────────────────────────────────────────────────────────
        // COLOR PALETTE (consistent across all forms)
        // ────────────────────────────────────────────────────────────
        public static readonly Color Primary       = Color.FromArgb(10, 61, 120);
        public static readonly Color PrimaryHover  = Color.FromArgb(15, 82, 158);
        public static readonly Color Accent        = Color.FromArgb(30, 136, 229);
        public static readonly Color AccentHover   = Color.FromArgb(21, 101, 192);
        public static readonly Color Success       = Color.FromArgb(39, 174, 96);
        public static readonly Color SuccessHover  = Color.FromArgb(30, 140, 75);
        public static readonly Color Danger        = Color.FromArgb(231, 76, 60);
        public static readonly Color DangerHover   = Color.FromArgb(192, 57, 43);
        public static readonly Color Warning       = Color.FromArgb(243, 156, 18);
        public static readonly Color Surface       = Color.White;
        public static readonly Color Background    = Color.FromArgb(245, 247, 250);
        public static readonly Color TextPrimary   = Color.FromArgb(44, 62, 80);
        public static readonly Color TextSecondary = Color.FromArgb(127, 140, 141);
        public static readonly Color BorderColor   = Color.FromArgb(218, 224, 232);

        // ────────────────────────────────────────────────────────────
        // DATAGRIDVIEW
        // ────────────────────────────────────────────────────────────
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
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Primary;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Primary;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgv.DefaultCellStyle.ForeColor = TextPrimary;
            dgv.DefaultCellStyle.SelectionBackColor = Accent;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(246, 249, 253);
        }

        // ────────────────────────────────────────────────────────────
        // BUTTON STYLES
        // ────────────────────────────────────────────────────────────
        public static void StylePrimaryButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Accent;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI Semibold", 10F);
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;

            btn.MouseEnter += (s, e) => btn.BackColor = AccentHover;
            btn.MouseLeave += (s, e) => btn.BackColor = Accent;
        }

        public static void StyleSuccessButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Success;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI Semibold", 10F);
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;

            btn.MouseEnter += (s, e) => btn.BackColor = SuccessHover;
            btn.MouseLeave += (s, e) => btn.BackColor = Success;
        }

        public static void StyleDangerButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Danger;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI Semibold", 10F);
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;

            btn.MouseEnter += (s, e) => btn.BackColor = DangerHover;
            btn.MouseLeave += (s, e) => btn.BackColor = Danger;
        }

        public static void StyleOutlineButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = BorderColor;
            btn.FlatAppearance.BorderSize = 1;
            btn.BackColor = Surface;
            btn.ForeColor = TextPrimary;
            btn.Font = new Font("Segoe UI", 10F);
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(245, 248, 252);
                btn.FlatAppearance.BorderColor = Accent;
                btn.ForeColor = Accent;
            };
            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Surface;
                btn.FlatAppearance.BorderColor = BorderColor;
                btn.ForeColor = TextPrimary;
            };
        }

        public static void StyleOtpButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Primary;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI Semibold", 9.5F);
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;

            btn.MouseEnter += (s, e) => btn.BackColor = PrimaryHover;
            btn.MouseLeave += (s, e) => btn.BackColor = Primary;
        }

        public static void StyleNavButton(Button btn, bool active = false)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI Semibold", 9.5F);
            btn.Padding = new Padding(12, 0, 0, 0);

            if (active)
            {
                btn.BackColor = Color.FromArgb(235, 243, 255);
                btn.ForeColor = Accent;
            }
            else
            {
                btn.BackColor = Surface;
                btn.ForeColor = TextPrimary;
            }

            btn.MouseEnter += (s, e) =>
            {
                if (btn.BackColor != Color.FromArgb(235, 243, 255))
                    btn.BackColor = Color.FromArgb(248, 249, 251);
            };
            btn.MouseLeave += (s, e) =>
            {
                if (btn.BackColor == Color.FromArgb(248, 249, 251))
                    btn.BackColor = Surface;
            };
        }

        // ────────────────────────────────────────────────────────────
        // INPUT STYLES
        // ────────────────────────────────────────────────────────────
        public static void StyleTextBox(TextBox txt)
        {
            txt.Font = new Font("Segoe UI", 10F);
            txt.ForeColor = TextPrimary;
            txt.BackColor = Surface;
            txt.BorderStyle = BorderStyle.FixedSingle;

            txt.GotFocus  += (s, e) => txt.BackColor = Color.FromArgb(235, 245, 255);
            txt.LostFocus += (s, e) => txt.BackColor = Surface;
        }

        public static void StyleComboBox(ComboBox cbo)
        {
            cbo.Font = new Font("Segoe UI", 10F);
            cbo.ForeColor = TextPrimary;
            cbo.BackColor = Surface;
            cbo.FlatStyle = FlatStyle.Flat;
        }

        // ────────────────────────────────────────────────────────────
        // CONTAINER STYLES
        // ────────────────────────────────────────────────────────────
        public static void StyleGroupBox(GroupBox grp)
        {
            grp.Font = new Font("Segoe UI Semibold", 9.5F);
            grp.ForeColor = Primary;
            grp.BackColor = Surface;
            grp.Padding = new Padding(16);
        }

        public static void StyleCard(Panel pn, Color? backColor = null)
        {
            pn.BackColor = backColor ?? Surface;
            pn.Padding = new Padding(16);
        }

        public static void StyleHeader(Panel pnHeader, Label lblTitle, Label lblSubtitle,
            string title, string subtitle)
        {
            pnHeader.BackColor = Primary;
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Height = 80;

            lblTitle.Text = title;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.AutoSize = false;
            lblTitle.Size = new Size(700, 30);
            lblTitle.Location = new Point(24, 16);

            lblSubtitle.Text = subtitle;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.AutoSize = false;
            lblSubtitle.Size = new Size(700, 20);
            lblSubtitle.Location = new Point(26, 48);
        }

        // ────────────────────────────────────────────────────────────
        // HOVER UTILITY
        // ────────────────────────────────────────────────────────────
        public static void ApplyHoverEffect(Control control, Color hoverColor, Color defaultColor)
        {
            control.MouseEnter += (s, e) => control.BackColor = hoverColor;
            control.MouseLeave += (s, e) => control.BackColor = defaultColor;
        }
    }
}
