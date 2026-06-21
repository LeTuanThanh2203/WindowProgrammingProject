using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    /// <summary>
    /// Dialog nhỏ cho phép người dùng chọn định dạng xuất: PDF hoặc Excel.
    /// Dùng: using (var dlg = new ExportFormatDialog()) { if (dlg.ShowDialog() == OK) { dlg.SelectedFormat ... } }
    /// </summary>
    public class ExportFormatDialog : Form
    {
        public string SelectedFormat { get; private set; } = "";

        private Button btnPDF;
        private Button btnExcel;
        private Button btnCancel;
        private Label lblTitle;

        public ExportFormatDialog()
        {
            BuildUI();
        }

        private void BuildUI()
        {
            // Form
            Text = "Export Format";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(360, 160);
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = Color.White;

            // Title
            lblTitle = new Label
            {
                Text = "Select export format:",
                Font = new Font("Segoe UI Semibold", 11F),
                ForeColor = Color.FromArgb(30, 40, 60),
                Location = new Point(20, 20),
                AutoSize = true
            };

            // PDF button
            btnPDF = new Button
            {
                Text = "📄  Export as PDF",
                Font = new Font("Segoe UI", 10F),
                Location = new Point(20, 65),
                Size = new Size(150, 42),
                BackColor = Color.FromArgb(10, 61, 120),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnPDF.FlatAppearance.BorderSize = 0;
            btnPDF.Click += (s, e) =>
            {
                SelectedFormat = "PDF";
                DialogResult = DialogResult.OK;
                Close();
            };

            // Excel button
            btnExcel = new Button
            {
                Text = "📊  Export as Excel",
                Font = new Font("Segoe UI", 10F),
                Location = new Point(185, 65),
                Size = new Size(155, 42),
                BackColor = Color.FromArgb(33, 115, 70),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.Click += (s, e) =>
            {
                SelectedFormat = "Excel";
                DialogResult = DialogResult.OK;
                Close();
            };

            // Cancel button
            btnCancel = new Button
            {
                Text = "Cancel",
                Font = new Font("Segoe UI", 9.5F),
                Location = new Point(130, 115),
                Size = new Size(100, 32),
                BackColor = Color.FromArgb(240, 243, 248),
                ForeColor = Color.FromArgb(60, 70, 85),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(200, 210, 225);
            btnCancel.Click += (s, e) =>
            {
                DialogResult = DialogResult.Cancel;
                Close();
            };

            Controls.AddRange(new Control[] { lblTitle, btnPDF, btnExcel, btnCancel });
        }
    }
}