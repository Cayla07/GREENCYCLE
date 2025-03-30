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
            this.mainForm = mainForm; // Store reference to `Main0`
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = UserAccount.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

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
            if (cbxShowPassL.Checked)
            {
                tbxPassL.UseSystemPasswordChar = true;
            }
            else
            {
                tbxPassL.UseSystemPasswordChar = false;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.12.0;Data Source=UserAccount.accdb"))
            {
                string email = tbxEmailL.Text;
                string password = tbxPassL.Text;

                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter your email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    con.Open();

                    // Query to check user credentials
                    string loginQuery = "SELECT COUNT(*) FROM UserAccount WHERE Email = ? AND Password = ?";
                    using (OleDbCommand cmd = new OleDbCommand(loginQuery, con))
                    {
                        cmd.Parameters.AddWithValue("Email", email);
                        cmd.Parameters.AddWithValue("Password", password);

                        int userExists = (int)cmd.ExecuteScalar();

                        if (userExists > 0)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Proceed to the main user dashboard
                            UserMain1 userDashboard = new UserMain1();
                            userDashboard.Show();

                            if (this.ParentForm is Main0 main0)
                            {
                                main0.Close();
                                main0.Dispose();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                finally
                {
                    con.Close();
                }
            }
        }


        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.ParentForm is Main0 functionalityForm)
            {
                functionalityForm.LoadFormIntoPanel(new UserSignUp1(functionalityForm)); // Pass Main0 reference
            }
        }
    }
}
