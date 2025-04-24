using GREENCYCLE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GREENCYCLE
{
    public partial class BaseForm : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;
        protected Form currentChildForm;
        protected Panel panelDisplay;

        public BaseForm()
        {
            this.MouseDown += BaseForm_MouseDown;
            this.MouseMove += BaseForm_MouseMove;
            this.MouseUp += BaseForm_MouseUp;

            this.WindowState = AppSettings.LastWindowState;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BaseForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                mouseOffset = new Point(e.X, e.Y);
            }
        }

        private void BaseForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Left += e.X - mouseOffset.X;
                this.Top += e.Y - mouseOffset.Y;
            }
        }

        private void BaseForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }


        protected void LoadFormIntoPanel(Form childForm)
        {
            if (currentChildForm != null && currentChildForm.GetType() == childForm.GetType())
                return;

            if (currentChildForm != null)
                currentChildForm.Hide();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelDisplay.Controls.Clear();
            panelDisplay.Controls.Add(childForm);
            childForm.Show();

            currentChildForm = childForm;
        }

        protected void HighlightButton(Button activeButton, List<Button> allButtons)
        {
            foreach (var btn in allButtons)
                btn.BackColor = Color.Transparent;

            activeButton.BackColor = Color.Lime;
        }

        protected void ToggleWindowState()
        {
            this.WindowState = (this.WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            AppSettings.LastWindowState = this.WindowState;
            UserTypePage UserTypePage = new UserTypePage();
            UserTypePage.Show();
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


    public static class AppSettings
    {
        public static FormWindowState LastWindowState = FormWindowState.Normal;
    }
}
