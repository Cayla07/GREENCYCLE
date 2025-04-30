namespace GREENCYCLE
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public partial class Receipt : Form
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public Dictionary<string, double> RecycleBag { get; set; }
        public double TotalPoints { get; set; }
        public Dictionary<string, double> MaterialPointMultipliers { get; set; }

        public Receipt(string fullName, string email, Dictionary<string, double> recycleBag, double totalPoints, Dictionary<string, double> materialPointMultipliers)
        {
            InitializeComponent();

            FullName = fullName;
            Email = email;
            RecycleBag = recycleBag;
            TotalPoints = totalPoints;
            MaterialPointMultipliers = materialPointMultipliers;

            // We manually call the setup here instead of using the Load event
            InitializeReceipt();
        }

        private void InitializeReceipt()
        {
            lblFullName.Text = FullName;
            lblEmail.Text = Email;
            lblTotal.Text = TotalPoints.ToString("F1");

            PopulateMaterials();
        }

        private void PopulateMaterials()
        {
            panelReceipt.Controls.Clear(); // Clear previous items first!
            panelReceipt.FlowDirection = FlowDirection.TopDown; // Arrange items vertically
            panelReceipt.WrapContents = false; // Disable wrapping
            panelReceipt.AutoScroll = true; // Enable scrolling

            foreach (var item in RecycleBag)
            {
                Panel materialPanel = new Panel
                {
                    Size = new Size(panelReceipt.ClientSize.Width - 10, 30), // Adjusted panel size
                    BackColor = Color.Transparent, // Optional: add background color
                    Margin = new Padding(5)
                };

                Label lblMaterial = new Label
                {
                    Text = item.Key,
                    AutoSize = false,
                    Size = new Size(200, 25),
                    Location = new Point(2, 7),
                    Font = new Font("Arial Rounded MT", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleLeft
                };

                Label lblWeight = new Label
                {
                    Text = $"{item.Value:F2} kg", // nicer formatting
                    AutoSize = false,
                    Size = new Size(95, 25),
                    Location = new Point(243, 8),
                    Font = new Font("Arial Rounded MT", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                int points = (int)(item.Value * (MaterialPointMultipliers.ContainsKey(item.Key) ? MaterialPointMultipliers[item.Key] : 10));
                Label lblPoints = new Label
                {
                    Text = $"{points:F1}",
                    AutoSize = false,
                    Size = new Size(50, 25),
                    Location = new Point(483, 7),
                    Font = new Font("Arial Rounded MT", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleRight
                };

                materialPanel.Controls.Add(lblMaterial);
                materialPanel.Controls.Add(lblWeight);
                materialPanel.Controls.Add(lblPoints);

                panelReceipt.Controls.Add(materialPanel);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {

        }
    }
}