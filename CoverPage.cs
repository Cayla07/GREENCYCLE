using System;

namespace GREENCYCLE
{
    public partial class CoverPage : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;
        public CoverPage()
        {
            InitializeComponent();

            this.MouseDown += CoverPage_MouseDown;
            this.MouseMove += CoverPage_MouseMove;
            this.MouseUp += CoverPage_MouseUp;
            this.WindowState = AppSettings.LastWindowState;
        }

        private void CoverPage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                mouseOffset = new Point(e.X, e.Y);
            }
        }

        private void CoverPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Left += e.X - mouseOffset.X;
                this.Top += e.Y - mouseOffset.Y;
            }
        }

        private void CoverPage_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            AppSettings.LastWindowState = this.WindowState;
            UserTypePage userTypePage = new UserTypePage();
            userTypePage.Show();
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
    public static class AppSettings
    {
        public static FormWindowState LastWindowState = FormWindowState.Normal;
    }
