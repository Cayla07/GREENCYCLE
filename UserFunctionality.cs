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
    public partial class UserFunctionality : Form
    {
        public UserFunctionality()
        {
            InitializeComponent();
        }

        private void UserFunctionality_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            tbxEmailC.KeyDown += new KeyEventHandler(tbxEmailC_KeyDown);
            tbxPassC.KeyDown += new KeyEventHandler(tbxPassC_KeyDown);
            tbxFullName.KeyDown += new KeyEventHandler(tbxFullName_KeyDown);
            tbxAge.KeyDown += new KeyEventHandler(tbxAge_KeyDown);
            tbxEmailL.KeyDown += new KeyEventHandler(tbxEmailL_KeyDown);

            cbxPayMeth.Items.Add("Gcash");
            cbxBarangay.Items.Add("Umapad");
            cbxBarangay.Items.Add("Opao");
            cbxMunicipality.Items.Add("Mandaue");
            cbxProvince.Items.Add("Cebu");
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

        private void tbxFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbxAge.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void tbxAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbxPhoneNum.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void tbxEmailL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbxPassL.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }


        private void linkUserLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelUserLogIn.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            panelCreate.Visible = true;
            panelInfo.Visible = false;

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelInfo.Visible = true;
            panelCreate.Visible = false;
            panelUserLogIn.Visible = false;

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
