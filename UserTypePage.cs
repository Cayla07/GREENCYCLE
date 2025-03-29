using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GREENCYCLE
{
    public partial class UserTypePage : Form
    {
        public UserTypePage()
        {
            InitializeComponent();
            this.WindowState = AppSettings.LastWindowState;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbType.Items.Add("Application Users");
            cmbType.Items.Add("Admin");
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem != null && !string.IsNullOrWhiteSpace(cmbType.SelectedItem.ToString()))
            {
                string selectedUserType = cmbType.SelectedItem.ToString().Trim();

                Main0 userFunctionality = new Main0();
                userFunctionality.WindowState = AppSettings.LastWindowState;

                if (selectedUserType == "Application Users")
                {
                    userFunctionality.Show();
                }
                else if (selectedUserType == "Admin")
                {
                    userFunctionality.Show();
                    userFunctionality.LoadFormIntoPanel(new Admin()); // Load Admin in panel
                }
                else
                {
                    MessageBox.Show("Invalid user type selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a user type!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            AppSettings.LastWindowState = this.WindowState;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}


