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
    public partial class UserLogIn : Form
    {
        public UserLogIn()
        {
            InitializeComponent();
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
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.ParentForm is Main0 functionalityForm)
            {
                functionalityForm.LoadFormIntoPanel(new UserSignUp1());
            }
        }
    }
}
