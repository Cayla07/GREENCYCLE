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
            timer1.Interval = 2000;
            timer1.Enabled = false;
            timer1.Tick += timer1_Tick;
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

        private void linkShowPassC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbxPassC.PasswordChar = '\0'; // Show password
            linkShowPassC.Text = "Hide";   // Change text to "Hide"

            // Start the timer to hide the password after 2 seconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbxPassC.PasswordChar = '*';  // Hide password again
            tbxPassL.PasswordChar = '*';
            linkShowPassC.Text = "Show";
            linkShowPassL.Text = "Show";   // Change text back to "Show"
            timer1.Stop();  // Stop the timer to avoid repeating
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            if (tbxPassC.Text == tbxConPass.Text)
            {
                MessageBox.Show("Created Successful!");
                // Proceed with saving the user details
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please try again.");
            }
        }

        private void linkUserLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelInfo.Visible = false;
            panelCreate.Visible = false;
            panelUserLogIn.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            panelCreate.Visible = true;
            panelInfo.Visible = false;
            panelUserLogIn.Visible = false;
        }

        private void linkShowPassL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbxPassL.PasswordChar = '\0'; // Show password
            linkShowPassL.Text = "Hide";   // Change text to "Hide"

            // Start the timer to hide the password after 2 seconds
            timer1.Start();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelInfo.Visible = true;
            panelCreate.Visible = false;
            panelUserLogIn.Visible = false;

        }
    }
}
