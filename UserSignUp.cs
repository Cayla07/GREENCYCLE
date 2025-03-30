using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class UserSignUp : Form
    {
        private Main0 mainForm; // Reference to Main0

        // Default constructor
        public UserSignUp()
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

            MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (this.ParentForm is Main0 main0)
            {
                main0.LoadFormIntoPanel(new UserLogIn(main0)); // Load the login form inside `Main0`
            }

            this.Hide(); // Hide 
        }

        private void cbShowPassA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassA.Checked)
            {
                tbxPassC.UseSystemPasswordChar = true;
            }
            else
            {
                tbxPassC.UseSystemPasswordChar = false;
            }
        }
    }
}
