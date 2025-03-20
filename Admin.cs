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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            tbxAdminEmail.KeyDown += new KeyEventHandler(tbxAdminEmail_KeyDown);
        }

        private void tbxAdminEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbxAdminPass.Focus();
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

        private void cbShowPassA_CheckedChanged(object sender, EventArgs e)
        {
            tbxAdminPass.UseSystemPasswordChar = cbShowPassA.Checked;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string adminEmail = "admin";
            string adminPassword = "admin123";

            if (tbxAdminEmail.Text == adminEmail && tbxAdminPass.Text == adminPassword)
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                UserDashboard dashboard = new UserDashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
