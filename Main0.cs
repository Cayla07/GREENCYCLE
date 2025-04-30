
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
    public partial class Main0 : Form
    {
        private Form activeForm = null; // Keeps track of the currently displayed form
        public Main0()
        {
            InitializeComponent();
            LoadFormIntoPanel(new UserLogIn(this));
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

            panelUser.Controls.Clear();  // Ensure only one form is loaded
            panelUser.Controls.Add(childForm);
            childForm.Show();

            activeForm = childForm;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
