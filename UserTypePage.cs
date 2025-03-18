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
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbType.Items.Add("Application Users");
            cmbType.Items.Add("Admin");
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem != null)
            {
                string selectedUserType = cmbType.SelectedItem.ToString();

                if (selectedUserType == "Application Users")
                {
                    UserFunctionality UserFunctionality = new UserFunctionality();
                    UserFunctionality.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Empty user type!");
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


    }
}

