using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class Recycle : Form
    {
        private UserMain1 parentForm;
        private Dictionary<string, double> recycleBag;

        public Recycle(UserMain1 parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            recycleBag = new Dictionary<string, double>();
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
                overlayForm.Size = new Size(1452, 7659);
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

        // When user clicks Plastic Bottles button
        private void btnPlastics_Click(object sender, EventArgs e)
        {
            PBInfo pbInfoForm = new PBInfo("Plastic Bottles", this);
            Overlay.ShowOverlay(this, pbInfoForm, null);
        }

        private void btnGlass_Click(object sender, EventArgs e)
        {
            GBInfo gbInfoForm = new GBInfo("Glass Bottles", this);
            Overlay.ShowOverlay(this, gbInfoForm, null);
        }

        private void btnCans_Click(object sender, EventArgs e)
        {
            DCInfo dcInfoForm = new DCInfo("Drink Cans", this);
            Overlay.ShowOverlay(this, dcInfoForm, null);
        }

        private void btnCartons_Click(object sender, EventArgs e)
        {
            CartonInfo cartonInfoForm = new CartonInfo("Drink Cartons", this);
            Overlay.ShowOverlay(this, cartonInfoForm, null);
        }

        private void btnPapers_Click(object sender, EventArgs e)
        {
            RPInfo rpInfoForm = new RPInfo("Recycled Papers", this);
            Overlay.ShowOverlay(this, rpInfoForm, null);
        }

        private void btnLids_Click(object sender, EventArgs e)
        {
            BLInfo blInfoForm = new BLInfo("Bottle Lids", this);
            Overlay.ShowOverlay(this, blInfoForm, null);
        }

        // Add to Recycle Bag dictionary
        public void AddToRecycleBag(string materialName, double weight)
        {
            if (recycleBag.ContainsKey(materialName))
            {
                recycleBag[materialName] += weight;
            }
            else
            {
                recycleBag.Add(materialName, weight);
            }

            UpdateRecycleBagDisplay();
        }

        // Update Recycle Bag Panel
        private void UpdateRecycleBagDisplay()
        {
            FLPanelRecycle.Controls.Clear();

            foreach (var item in recycleBag)
            {
                Panel materialPanel = new Panel
                {
                    Size = new Size(743, 50),
                    BackColor = Color.LightGreen,
                    Margin = new Padding(5)
                };

                Label lblMaterial = new Label
                {
                    Text = item.Key,
                    Font = new Font("Arial Rounded MT", 10, FontStyle.Bold),
                    AutoSize = false,
                    Size = new Size(160, 30),
                    Location = new Point(10, 10),
                    TextAlign = ContentAlignment.MiddleLeft
                };

                Label lblWeight = new Label
                {
                    Text = $"{item.Value} kg",
                    Font = new Font("Arial Rounded MT", 10, FontStyle.Bold),
                    AutoSize = false,
                    Size = new Size(120, 30),
                    Location = new Point(180, 10),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                int points = (int)(item.Value * 10);
                Label lblPoints = new Label
                {
                    Text = $"{points} pts",
                    Font = new Font("Arial Rounded MT", 10, FontStyle.Bold),
                    AutoSize = false,
                    Size = new Size(120, 30),
                    Location = new Point(320, 10),
                    TextAlign = ContentAlignment.MiddleRight
                };

                materialPanel.Controls.Add(lblMaterial);
                materialPanel.Controls.Add(lblWeight);
                materialPanel.Controls.Add(lblPoints);

                FLPanelRecycle.Controls.Add(materialPanel);
            }
        }

        private void Recycle_Load(object sender, EventArgs e)
        {
            // Initialize if needed
        }
    }
}
