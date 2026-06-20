using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_MenuManagement : Form
    {
        private readonly f_Main _mainForm;
        private DataTable _menuTable;

        public f_MenuManagement(f_Main mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            this.Load += f_MenuManagement_Load;
            btnMoveUp.Click += btnMoveUp_Click;
            btnMoveDown.Click += btnMoveDown_Click;
            btnSave.Click += btnSave_Click;
            btnReset.Click += btnReset_Click;
        }

        private void f_MenuManagement_Load(object sender, EventArgs e)
        {
            LoadMenuConfig();
        }

        private void LoadMenuConfig()
        {
            _menuTable = new DataTable();
            using (My_DB db = new My_DB())
            {
                string query = "SELECT ButtonName, DisplayName, IconCharName, DisplayOrder, AllowAdmin, AllowManager, AllowUser FROM MenuConfig WHERE ButtonName != 'btnMenuManagement' ORDER BY DisplayOrder ASC";
                using (SqlCommand cmd = new SqlCommand(query, db.getConnection))
                {
                    try
                    {
                        db.openConnection();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(_menuTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading menu config: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            dgvMenuConfig.DataSource = _menuTable;
            ConfigureGrid();
        }

        private void ConfigureGrid()
        {
            UIStyleHelper.StyleDataGridView(dgvMenuConfig);

            // Allow columns editing
            dgvMenuConfig.ReadOnly = false;

            // Configure specific columns
            if (dgvMenuConfig.Columns["ButtonName"] != null)
            {
                dgvMenuConfig.Columns["ButtonName"].ReadOnly = true;
                dgvMenuConfig.Columns["ButtonName"].HeaderText = "Button Code";
                dgvMenuConfig.Columns["ButtonName"].Visible = false; // Hide technical names
            }

            if (dgvMenuConfig.Columns["DisplayName"] != null)
            {
                dgvMenuConfig.Columns["DisplayName"].ReadOnly = false;
                dgvMenuConfig.Columns["DisplayName"].HeaderText = "Menu Name";
            }

            if (dgvMenuConfig.Columns["IconCharName"] != null)
            {
                dgvMenuConfig.Columns["IconCharName"].ReadOnly = true;
                dgvMenuConfig.Columns["IconCharName"].HeaderText = "Icon";
                dgvMenuConfig.Columns["IconCharName"].Visible = false;
            }

            if (dgvMenuConfig.Columns["DisplayOrder"] != null)
            {
                dgvMenuConfig.Columns["DisplayOrder"].ReadOnly = true;
                dgvMenuConfig.Columns["DisplayOrder"].HeaderText = "Order";
                dgvMenuConfig.Columns["DisplayOrder"].Width = 60;
            }

            // Checkbox columns
            SetCheckboxColumn("AllowAdmin", "Admin Access");
            SetCheckboxColumn("AllowManager", "Manager Access");
            SetCheckboxColumn("AllowUser", "User Access");
        }

        private void SetCheckboxColumn(string columnName, string headerText)
        {
            if (dgvMenuConfig.Columns[columnName] != null)
            {
                dgvMenuConfig.Columns[columnName].ReadOnly = false;
                dgvMenuConfig.Columns[columnName].HeaderText = headerText;
            }
        }

        // ================= MOVE UP =================
        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (dgvMenuConfig.SelectedRows.Count == 0) return;

            int selectedIndex = dgvMenuConfig.SelectedRows[0].Index;
            if (selectedIndex <= 0) return; // Already at the top

            SwapRows(selectedIndex, selectedIndex - 1);
        }

        // ================= MOVE DOWN =================
        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (dgvMenuConfig.SelectedRows.Count == 0) return;

            int selectedIndex = dgvMenuConfig.SelectedRows[0].Index;
            if (selectedIndex >= dgvMenuConfig.Rows.Count - 1) return; // Already at the bottom

            SwapRows(selectedIndex, selectedIndex + 1);
        }

        private void SwapRows(int indexA, int indexB)
        {
            DataRow rowA = _menuTable.Rows[indexA];
            DataRow rowB = _menuTable.Rows[indexB];

            // Swap DisplayOrder values
            object tempOrder = rowA["DisplayOrder"];
            rowA["DisplayOrder"] = rowB["DisplayOrder"];
            rowB["DisplayOrder"] = tempOrder;

            // Save display order swaps to database immediately to preserve sequencing
            SaveDisplayOrders(rowA, rowB);

            // Reload from database to ensure fresh state and sorting
            LoadMenuConfig();

            // Reselect the moved item
            dgvMenuConfig.ClearSelection();
            dgvMenuConfig.Rows[indexB].Selected = true;
        }

        private void SaveDisplayOrders(DataRow rowA, DataRow rowB)
        {
            using (My_DB db = new My_DB())
            {
                try
                {
                    db.openConnection();
                    string query = @"
                        UPDATE MenuConfig SET DisplayOrder = @orderA WHERE ButtonName = @nameA;
                        UPDATE MenuConfig SET DisplayOrder = @orderB WHERE ButtonName = @nameB;";

                    using (SqlCommand cmd = new SqlCommand(query, db.getConnection))
                    {
                        cmd.Parameters.AddWithValue("@orderA", rowA["DisplayOrder"]);
                        cmd.Parameters.AddWithValue("@nameA", rowA["ButtonName"]);
                        cmd.Parameters.AddWithValue("@orderB", rowB["DisplayOrder"]);
                        cmd.Parameters.AddWithValue("@nameB", rowB["ButtonName"]);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving display order: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.closeConnection();
                }
            }
        }

        // ================= SAVE CHANGES =================
        private void btnSave_Click(object sender, EventArgs e)
        {
            // End edit to commit changes from DGV to DataTable
            dgvMenuConfig.EndEdit();

            using (My_DB db = new My_DB())
            {
                try
                {
                    db.openConnection();
                    foreach (DataRow row in _menuTable.Rows)
                    {
                        string query = @"
                            UPDATE MenuConfig 
                            SET DisplayName = @displayName,
                                AllowAdmin = @allowAdmin,
                                AllowManager = @allowManager,
                                AllowUser = @allowUser
                            WHERE ButtonName = @buttonName";

                        using (SqlCommand cmd = new SqlCommand(query, db.getConnection))
                        {
                            cmd.Parameters.AddWithValue("@displayName", row["DisplayName"]);
                            cmd.Parameters.AddWithValue("@allowAdmin", row["AllowAdmin"]);
                            cmd.Parameters.AddWithValue("@allowManager", row["AllowManager"]);
                            cmd.Parameters.AddWithValue("@allowUser", row["AllowUser"]);
                            cmd.Parameters.AddWithValue("@buttonName", row["ButtonName"]);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Menu settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the main form sidebar dynamically
                    _mainForm.RefreshMenu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving changes: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.closeConnection();
                }
            }
        }

        // ================= RESET DEFAULTS =================
        private void btnReset_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to reset the menu to default settings?", "Reset Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            using (My_DB db = new My_DB())
            {
                try
                {
                    db.openConnection();
                    
                    // Drop the table and re-initialize it
                    string dropQuery = "IF OBJECT_ID('MenuConfig', 'U') IS NOT NULL DROP TABLE MenuConfig";
                    using (SqlCommand dropCmd = new SqlCommand(dropQuery, db.getConnection))
                    {
                        dropCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Menu has been reset to defaults.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Re-initialize and reload
                    MenuConfigDbHelper.InitializeMenuConfigTable();
                    LoadMenuConfig();
                    
                    // Refresh main form menu
                    _mainForm.RefreshMenu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error resetting menu: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.closeConnection();
                }
            }
        }
    }
}
