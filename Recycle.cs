using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class Recycle : Form
    {
        private UserMain1 parentForm;
        private Dictionary<string, double> recycleBag;
        private Dictionary<string, int> materialPointMultipliers = new Dictionary<string, int>();

        // ✅ Correct place for readonly connectionString
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maica eupinado\Documents\GreenCycleDatabase.accdb;Persist Security Info=False;";

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
                var overlayForm = new Form
                {
                    StartPosition = FormStartPosition.CenterScreen,
                    FormBorderStyle = FormBorderStyle.None,
                    Opacity = 0.5d,
                    BackColor = Color.Black,
                    Size = new Size(1452, 7659),
                    Location = owner.Location,
                    ShowInTaskbar = false
                };

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

        // Material buttons
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

        // Add to recycle bag
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

        // Update recycle bag display
        // Update recycle bag display
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

                int pointsPerKg = materialPointMultipliers.ContainsKey(item.Key) ? materialPointMultipliers[item.Key] : 10; // fallback 10 if not found
                int points = (int)(item.Value * pointsPerKg);

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

        private void LoadMaterialPointsFromDatabase()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT MaterialName, Points FROM [MaterialPoints]"; // ✅ better table name
                    OleDbCommand command = new OleDbCommand(query, connection);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        materialPointMultipliers.Clear(); // Clear old data

                        while (reader.Read())
                        {
                            string materialName = reader["MaterialName"].ToString();
                            int points = Convert.ToInt32(reader["Points"]);

                            materialPointMultipliers[materialName] = points;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading material points: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Recycle_Load(object sender, EventArgs e)
        {
            LoadMaterialPointsFromDatabase();
        }
    }
}
