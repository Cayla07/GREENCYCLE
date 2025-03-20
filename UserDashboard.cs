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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void DisableButton()
        {
            btnDashboard.BackColor = Color.Transparent;
            btnRecycle.BackColor = Color.Transparent;
            btnWallet.BackColor = Color.Transparent;
            btnTransaction.BackColor = Color.Transparent;
            btnHistory.BackColor = Color.Transparent;
            btnSettings.BackColor = Color.Transparent;
            btnOut.BackColor = Color.Transparent;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DisableButton();
            btnDashboard.BackColor = Color.Lime;
        }

        private void btnRecycle_Click(object sender, EventArgs e)
        {
            DisableButton();
            btnRecycle.BackColor = Color.Lime;
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            DisableButton();
            btnWallet.BackColor = Color.Lime;
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            DisableButton();
            btnTransaction.BackColor = Color.Lime;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            DisableButton();
            btnHistory.BackColor = Color.Lime;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            DisableButton();
            btnSettings.BackColor = Color.Lime;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DisableButton();
            btnOut.BackColor = Color.Lime;
            CoverPage coverpage = new CoverPage();
            coverpage.Show();
            this.Hide();
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
