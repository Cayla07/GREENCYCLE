using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GREENCYCLE
{
    public partial class UserSignUp : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        private Main0 mainForm; // Reference to Main0

        public UserSignUp(Main0 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void UserSignUp_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            tbxEmailC.KeyDown += new KeyEventHandler(tbxEmailC_KeyDown);
            tbxPassC.KeyDown += new KeyEventHandler(tbxPassC_KeyDown);
        }

        private void tbxEmailC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbxPassC.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void tbxPassC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbxConPass.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            string email = tbxEmailC.Text;
            string password = tbxPassC.Text;
            string confirmPassword = tbxConPass.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maica eupinado\Documents\GreenCycleDatabase.accdb;";
                using (OleDbConnection myConn = new OleDbConnection(connString))
                {
                    myConn.Open();

                    // 1️⃣ Check if email already exists
                    string checkQuery = "SELECT COUNT(*) FROM UserAccount WHERE Email = @Email";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, myConn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Email already exists. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // 2️⃣ Insert new user if email is unique
                    string insertQuery = "INSERT INTO UserAccount (Email, [Password]) VALUES (@Email, @Password)";
                    using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, myConn))
                    {
                        insertCmd.Parameters.AddWithValue("@Email", email);
                        insertCmd.Parameters.AddWithValue("@Password", password); // ⚠ Password should be hashed for security

                        int result = insertCmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (this.ParentForm is Main0 main0)
                            {
                                main0.LoadFormIntoPanel(new UserLogIn(main0)); // Redirect to login
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Account creation failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cbShowPassA_CheckedChanged(object sender, EventArgs e)
        {
            tbxPassC.UseSystemPasswordChar = cbShowPassA.Checked;
        }
    }
}