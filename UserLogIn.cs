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
    public partial class UserLogIn : Form
    {
        private Main0 mainForm;

        public UserLogIn()
        {
            InitializeComponent();
        }

        public UserLogIn(Main0 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        private void UserLogIn_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            tbxEmailL.KeyDown += new KeyEventHandler(tbxEmailL_KeyDown);
        }

        private void tbxEmailL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbxPassL.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cbxShowPassL_CheckedChanged(object sender, EventArgs e)
        {
            tbxPassL.UseSystemPasswordChar = !cbxShowPassL.Checked;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string email = tbxEmailL.Text;
            string password = tbxPassL.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both Email and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maica eupinado\Documents\GreenCycleDatabase.accdb;";

            using (OleDbConnection myConn = new OleDbConnection(connString))
            {
                try
                {
                    myConn.Open();

                    string loginQuery = "SELECT AccountID, Email FROM UserAccounts WHERE Email = @Email AND [Password] = @Password";
                    using (OleDbCommand cmd = new OleDbCommand(loginQuery, myConn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int loggedInAccountID = Convert.ToInt32(reader["accountID"]);
                                string loggedInEmail = reader["Email"].ToString();

                                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UserMain1 userDashboard = new UserMain1(loggedInAccountID); 
                                userDashboard.Email = loggedInEmail; 
                                                                     
                                userDashboard.Show();
                                mainForm?.Close();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Email or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (myConn.State == ConnectionState.Open)
                    {
                        myConn.Close();
                    }
                }
            }
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.LoadFormIntoPanel(new UserSignUp1(mainForm));
            }
        }
    }
}