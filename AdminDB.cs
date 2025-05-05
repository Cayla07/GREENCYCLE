using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class AdminDB : Form
    {
        private AdminMain1 parentForm;
        private const string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb";

        public AdminDB(AdminMain1 parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void AdminDB_Load(object sender, EventArgs e)
        {
            LoadUsersToFlowPanel();
        }

        private void LoadUsersToFlowPanel()
        {
            FLPanelUser.Controls.Clear();

            string query = @"SELECT UserAccounts.AccountID, UserAccounts.Email, UserAccounts.Password,UserInfos.FullName, UserInfos.PhoneNumber, UserInfos.Province,
               UserInfos.Municipality, UserInfos.Barangay FROM UserInfos INNER JOIN UserAccounts ON UserInfos.UserInfosID = UserAccounts.AccountID";

            try
            {
                using var conn = new OleDbConnection(ConnectionString);
                conn.Open();
                using var cmd = new OleDbCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Panel userPanel = new Panel
                    {
                        Width = 400,
                        Height = 120,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(10)
                    };

                    Label lblInfo = new Label
                    {
                        AutoSize = true,
                        Text = "Name: " + reader["FullName"] + Environment.NewLine +
                               "Email: " + reader["Email"] + Environment.NewLine +
                               "Phone: " + reader["PhoneNumber"] + Environment.NewLine +
                               "Location: " + reader["Province"] + ", " + reader["Municipality"] + ", " + reader["Barangay"],
                        Font = new Font("Segoe UI", 9),
                        Location = new Point(10, 10)
                    };

                    userPanel.Controls.Add(lblInfo);
                    FLPanelUser.Controls.Add(userPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
