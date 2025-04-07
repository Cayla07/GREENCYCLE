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

        // Form instances for reuse
        private Recycle recycleForm;
     //   private Wallet walletForm;
      //  private Transaction transactionForm;
    //    private History historyForm;
      //  private Settings settingsForm;

        public UserMain1()
        {
            InitializeComponent();
            HighlightButton(btnDashboard);
            recycleForm = new Recycle(this); 
            LoadFormIntoPanel(recycleForm);
        }

        public void LoadFormIntoPanel(Form childForm)
        {
            if (activeForm != null && activeForm.GetType() == childForm.GetType())
                return;

            if (activeForm != null)
            {
                activeForm.Hide();
            }

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
            recycleForm = new Recycle(this); // Assuming Recycle is dashboard
            LoadFormIntoPanel(recycleForm);
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
