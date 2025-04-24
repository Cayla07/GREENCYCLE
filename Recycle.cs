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
    public partial class Recycle : Form
    {
        private UserMain1 parentForm;
        public Recycle(UserMain1 parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }
        public static class Overlay
        {
            public static void ShowOverlay(Form owner, Form newForm, Form dialog)
            {
                var overlayForm = new Form();
                overlayForm.StartPosition = FormStartPosition.CenterScreen;
                overlayForm.FormBorderStyle = FormBorderStyle.None;
                overlayForm.Opacity = 0.5d;
                overlayForm.BackColor = Color.Black;
                overlayForm.Size = new Size(1153, 709);
                overlayForm.Location = owner.Location;
                overlayForm.ShowInTaskbar = false;

                if (dialog != null)
                {
                    overlayForm.Show();
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        dialog.Close();
                        overlayForm.Close();
                    }
                }
                else
                {
                    overlayForm.Show();
                    newForm.FormClosed += (s, args) => overlayForm.Close();
                    newForm.Show();
                    newForm.BringToFront();
                }
            }
        }
        private void btnPlastics_Click(object sender, EventArgs e)
        {
            PBInfo pbInfoForm = new PBInfo();
            Overlay.ShowOverlay(this, pbInfoForm, null);
        }

        private void btnGlass_Click(object sender, EventArgs e)
        {
            GBInfo gbInfoForm = new GBInfo();
            Overlay.ShowOverlay(this, gbInfoForm, null);
        }

        private void btnCans_Click(object sender, EventArgs e)
        {
            DCInfo dcInfoForm = new DCInfo();
            Overlay.ShowOverlay(this, dcInfoForm, null);
        }

        private void btnCartons_Click(object sender, EventArgs e)
        {
            CartonInfo cartonInfoForm = new CartonInfo();
            Overlay.ShowOverlay(this, cartonInfoForm, null);
        }

        private void btnPapers_Click(object sender, EventArgs e)
        {
            RPInfo rpInfoForm = new RPInfo();
            Overlay.ShowOverlay(this, rpInfoForm, null);
        }

        private void btnLids_Click(object sender, EventArgs e)
        {
            BLInfo blInfoForm = new BLInfo();
            Overlay.ShowOverlay(this, blInfoForm, null);
        }
    }
}
