
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
        private Main0 mainForm;
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(Main0 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
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
                AdminMain1 admindashboard = new AdminMain1();
                admindashboard.Show();

                if (this.ParentForm is Main0 main0)
                {
                    main0.Close(); // Close `Main0`
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxAdminPass.Clear();
                tbxAdminPass.Focus();
            }
        }
    }
}
