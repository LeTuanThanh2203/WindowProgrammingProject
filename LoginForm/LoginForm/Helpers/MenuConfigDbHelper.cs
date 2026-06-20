using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Windows.Forms;

namespace LoginForm
{
    public static class MenuConfigDbHelper
    {
        public static void InitializeMenuConfigTable()
        {
            using (My_DB db = new My_DB())
            {
                try
                {
                    db.openConnection();

                    // Check if MenuConfig table exists
                    string checkTableQuery = "SELECT COUNT(*) FROM sys.tables WHERE name = 'MenuConfig'";
                    using (SqlCommand checkCmd = new SqlCommand(checkTableQuery, db.getConnection))
                    {
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            // Create MenuConfig table
                            string createTableQuery = @"
                                CREATE TABLE MenuConfig (
                                    ButtonName VARCHAR(50) PRIMARY KEY,
                                    DisplayName NVARCHAR(100) NOT NULL,
                                    IconCharName VARCHAR(50) NOT NULL,
                                    DisplayOrder INT NOT NULL,
                                    AllowAdmin BIT NOT NULL,
                                    AllowManager BIT NOT NULL,
                                    AllowUser BIT NOT NULL
                                )";
                            using (SqlCommand createCmd = new SqlCommand(createTableQuery, db.getConnection))
                            {
                                createCmd.ExecuteNonQuery();
                            }

                            // Insert default menu items with initial display orders and role permissions
                            string insertDefaultsQuery = @"
                                INSERT INTO MenuConfig (ButtonName, DisplayName, IconCharName, DisplayOrder, AllowAdmin, AllowManager, AllowUser) VALUES
                                ('btnOverview', 'Dashboard', 'HomeUser', 1, 1, 1, 0),
                                ('btnStudent', 'Student', 'UserGraduate', 2, 1, 1, 0),
                                ('btnApprove', 'Approve', 'CheckCircle', 3, 1, 0, 0),
                                ('btnCourse', 'Courses', 'BookOpen', 4, 1, 1, 0),
                                ('btnCourseRegistation', 'Courses Registation', 'ClipboardList', 5, 0, 0, 1),
                                ('btnScore', 'Score', 'MortarBoard', 6, 1, 1, 0),
                                ('btnInformation', 'Information', 'MortarBoard', 7, 0, 0, 1),
                                ('btnClass', 'Class', 'MortarBoard', 8, 1, 1, 0),
                                ('btnConfirmationRequest', 'Confirmation Request', 'MortarBoard', 9, 0, 0, 1),
                                ('btnAssign', 'Assign', 'NetworkWired', 10, 1, 1, 0),
                                ('btnContact', 'Contact', 'Phone', 11, 1, 1, 1),
                                ('btnExport', 'Export', 'Print', 12, 1, 1, 0),
                                ('btnMenuManagement', 'Menu Manage', 'Sliders', 13, 1, 0, 0),
                                ('btnSchedule', 'Schedule', 'CalendarAlt', 14, 0, 0, 1)";
                            
                            using (SqlCommand insertCmd = new SqlCommand(insertDefaultsQuery, db.getConnection))
                            {
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Check and insert missing btnSchedule for existing installations
                            string checkRowQuery = "SELECT COUNT(*) FROM MenuConfig WHERE ButtonName = 'btnSchedule'";
                            using (SqlCommand checkRowCmd = new SqlCommand(checkRowQuery, db.getConnection))
                            {
                                int rowCount = Convert.ToInt32(checkRowCmd.ExecuteScalar());
                                if (rowCount == 0)
                                {
                                    string insertRowQuery = "INSERT INTO MenuConfig (ButtonName, DisplayName, IconCharName, DisplayOrder, AllowAdmin, AllowManager, AllowUser) VALUES ('btnSchedule', 'Schedule', 'CalendarAlt', 14, 0, 0, 1)";
                                    using (SqlCommand insertRowCmd = new SqlCommand(insertRowQuery, db.getConnection))
                                    {
                                        insertRowCmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error initializing MenuConfig table: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.closeConnection();
                }
            }
        }
    }
}
