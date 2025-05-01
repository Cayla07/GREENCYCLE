using System;
using System.Drawing;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class UserMain1 : Form
    {
        private Form activeForm = null;

        private Recycle recycleForm;
        private UserDB userDBForm;
        private History historyForm;

        public int LoggedInAccountID { get; private set; }
        public string Email { get; set; } // ✅ Added Email property
        public string FullName { get; set; }
        public UserMain1(int AccountID)
        {
            InitializeComponent();
            HighlightButton(btnDashboard);
            LoggedInAccountID = AccountID;
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
            // Wallet form logic
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            HighlightButton(btnTransaction);
            // Transaction form logic
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HighlightButton(btnHistory);
            if (historyForm == null || historyForm.IsDisposed)
                historyForm = new History(this.Email, this);

            LoadFormIntoPanel(historyForm);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            HighlightButton(btnSettings);
            // Settings form logic
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

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UserMain1_Load(object sender, EventArgs e)
        {

        }
    }
}
