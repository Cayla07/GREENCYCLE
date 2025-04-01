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
            UserMain1 userDashboard = new UserMain1();
            userDashboard.Show();

            if (mainForm != null)
            {
                mainForm.Close(); // Fully closes Main0
                mainForm.Dispose(); // Releases resources
            }

            this.Hide(); // Hide
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