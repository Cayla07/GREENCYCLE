using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class UserMain1 : Form
    {
        private Form activeForm = null;

        // Forms for reuse
        private Recycle recycleForm;
        private UserDB userDBForm;

        public UserMain1()
        {
            InitializeComponent();
            HighlightButton(btnDashboard);

            userDBForm = new UserDB(this);
            LoadFormIntoPanel(userDBForm);
        }

        public void LoadFormIntoPanel(Form childForm)
        {
            if (activeForm != null && activeForm.GetType() == childForm.GetType())
                return;

            if (activeForm != null)
                activeForm.Hide();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            paneldisplayDB.Controls.Clear();
            paneldisplayDB.Controls.Add(childForm);
            childForm.Show();

            activeForm = childForm;
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

        private void HighlightButton(Button btn)
        {
            DisableButton();
            btn.BackColor = Color.Lime;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HighlightButton(btnDashboard);
            paneldisplayDB.Visible = true;

            if (userDBForm == null || userDBForm.IsDisposed)
                userDBForm = new UserDB(this);

            LoadFormIntoPanel(userDBForm);
        }

        private void btnRecycle_Click(object sender, EventArgs e)
        {
            HighlightButton(btnRecycle);

            if (recycleForm == null || recycleForm.IsDisposed)
                recycleForm = new Recycle(this);

            LoadFormIntoPanel(recycleForm);
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            HighlightButton(btnWallet);
            // Add Wallet form logic here
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            HighlightButton(btnTransaction);
            // Add Transaction form logic here
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HighlightButton(btnHistory);
            // Add History form logic here
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            HighlightButton(btnSettings);
            // Add Settings form logic here
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            HighlightButton(btnOut);
            CoverPage coverpage = new CoverPage();
            coverpage.Show();
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click_1(object sender, EventArgs e)
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

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
