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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void DisableButton()
        {
            btnDashboard.BackColor = Color.Transparent;
            btnUsers.BackColor = Color.Transparent;
            btnEditRates.BackColor = Color.Transparent;
            btnEditTypes.BackColor = Color.Transparent;
            btnStatistics.BackColor = Color.Transparent;
            btnSettings.BackColor = Color.Transparent;
            btnOut.BackColor = Color.Transparent;
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

        private void btnOut_Click(object sender, EventArgs e)
        {
            DisableButton();
            btnOut.BackColor = Color.Lime;
            CoverPage coverpage = new CoverPage();
            coverpage.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DisableButton();
            btnDashboard.BackColor = Color.Lime;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            DisableButton();
            btnUsers.BackColor = Color.Lime;
        }

        private void btnEditRates_Click(object sender, EventArgs e)
        {
            DisableButton();
            btnEditRates.BackColor = Color.Lime;
        }

        private void btnEditTypes_Click(object sender, EventArgs e)
        {
            DisableButton();
            btnEditTypes.BackColor = Color.Lime;
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            DisableButton();
            btnStatistics.BackColor = Color.Lime;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            DisableButton();
            btnSettings.BackColor = Color.Lime;
        }
    }
}
