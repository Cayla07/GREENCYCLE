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
        private Dictionary<string, double> materialPointMultipliers = new Dictionary<string, double>();

        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maica eupinado\Documents\GreenCycleDatabase.accdb;Persist Security Info=False;";
        private string loggedInEmail; 

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
                    Size = new Size(1452, 765),
                    Location = owner.Location,
                    ShowInTaskbar = true
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

        private void Recycle_Load(object sender, EventArgs e)
        {
            LoadMaterialPointsFromDatabase();
            if (parentForm != null)
            {
                loggedInEmail = parentForm.Email;
                LoadRecycleBagFromDatabase();
            }
        }

        private void LoadMaterialPointsFromDatabase()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT MaterialName, Points FROM [MaterialPoints]";
                    OleDbCommand command = new OleDbCommand(query, connection);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        materialPointMultipliers.Clear();

                        while (reader.Read())
                        {
                            string materialName = reader["MaterialName"].ToString();
                            double points = double.Parse(reader["Points"].ToString());

                            materialPointMultipliers[materialName] = points;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading material points: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRecycleBagFromDatabase()
        {
            try
            {
                recycleBag.Clear();
                if (!string.IsNullOrEmpty(loggedInEmail))
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT MaterialName, Points FROM RecycleBag WHERE Email = ?";
                        OleDbCommand command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("?", loggedInEmail);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string material = reader["MaterialName"].ToString();
                                double points = Convert.ToDouble(reader["Points"]);
                                double multiplier = materialPointMultipliers.ContainsKey(material) ? materialPointMultipliers[material] : 10;
                                double weight = points / multiplier;

                                if (recycleBag.ContainsKey(material))
                                {
                                    recycleBag[material] += weight;
                                }
                                else
                                {
                                    recycleBag[material] = weight;
                                }
                            }
                        }
                    }
                }
                UpdateRecycleBagDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recycle bag: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddToRecycleBag(string materialName, double weight)
        {
            if (recycleBag.ContainsKey(materialName))
            {
                recycleBag[materialName] += weight;
            }
            else
            {
                recycleBag[materialName] = weight;
            }

            SaveMaterialToDatabase(materialName, recycleBag[materialName]);
            UpdateRecycleBagDisplay();
        }

        private void SaveMaterialToDatabase(string materialName, double totalWeight)
        {
            if (!string.IsNullOrEmpty(loggedInEmail))
            {
                try
                {
                    double points = totalWeight * (materialPointMultipliers.ContainsKey(materialName) ? materialPointMultipliers[materialName] : 10);

                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM RecycleBag WHERE Email = ? AND MaterialName = ?";
                        OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, connection);
                        deleteCmd.Parameters.AddWithValue("?", loggedInEmail);
                        deleteCmd.Parameters.AddWithValue("?", materialName);
                        deleteCmd.ExecuteNonQuery();

                        string insertQuery = "INSERT INTO RecycleBag (Email, MaterialName, Points) VALUES (?, ?, ?)";
                        OleDbCommand insertCmd = new OleDbCommand(insertQuery, connection);
                        insertCmd.Parameters.AddWithValue("?", loggedInEmail);
                        insertCmd.Parameters.AddWithValue("?", materialName);
                        insertCmd.Parameters.AddWithValue("?", points);
                        insertCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving material: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateRecycleBagDisplay()
        {
            FLPanelRecycle.Controls.Clear();

            foreach (var item in recycleBag)
            {
                Panel materialPanel = new Panel
                {
                    Size = new Size(735, 50),
                    BackColor = Color.Turquoise,
                    Margin = new Padding(3)
                };

                Label lblMaterial = new Label
                {
                    Text = item.Key,
                    Font = new Font("Arial Rounded MT", 10, FontStyle.Bold),
                    AutoSize = false,
                    Size = new Size(240, 30),
                    Location = new Point(3, 6),
                    TextAlign = ContentAlignment.MiddleLeft
                };

                Label lblWeight = new Label
                {
                    Text = $"{item.Value} kg",
                    Font = new Font("Arial Rounded MT", 10, FontStyle.Bold),
                    AutoSize = false,
                    Size = new Size(110, 30),
                    Location = new Point(303, 4),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                double pointsPerKg = materialPointMultipliers.ContainsKey(item.Key) ? materialPointMultipliers[item.Key] : 10;
                double points = item.Value * pointsPerKg;

                Label lblPoints = new Label
                {
                    Text = $"{points:F1} pts",
                    Font = new Font("Arial Rounded MT", 10, FontStyle.Bold),
                    AutoSize = false,
                    Size = new Size(110, 30),
                    Location = new Point(603, 4),
                    TextAlign = ContentAlignment.MiddleRight
                };

                materialPanel.Controls.Add(lblMaterial);
                materialPanel.Controls.Add(lblWeight);
                materialPanel.Controls.Add(lblPoints);

                FLPanelRecycle.Controls.Add(materialPanel);
            }
        }

        private double CalculateTotalPoints()
        {
            double total = 0;
            foreach (var item in recycleBag)
            {
                double pointsPerKg = materialPointMultipliers.ContainsKey(item.Key) ? materialPointMultipliers[item.Key] : 10;
                total += item.Value * pointsPerKg;
            }
            return total;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fullName = parentForm.FullName;
            string email = parentForm.Email;
            double totalPoints = CalculateTotalPoints();

            string details = "";
            foreach (var item in recycleBag)
            {
                details += $"{item.Value} kg {item.Key}, ";
            }
            if (details.EndsWith(", "))
            {
                details = details.Substring(0, details.Length - 2); 
            }
            Receipt receiptForm = new Receipt(fullName, email, recycleBag, totalPoints, materialPointMultipliers);

            Overlay.ShowOverlay(this, receiptForm, null);

            ClearRecycleBagFromDatabase();
            recycleBag.Clear();
            UpdateRecycleBagDisplay();
        }


        private void ClearRecycleBagFromDatabase()
        {
            if (!string.IsNullOrEmpty(loggedInEmail))
            {
                try
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM RecycleBag WHERE Email = ?";
                        OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, connection);
                        deleteCmd.Parameters.AddWithValue("?", loggedInEmail);
                        deleteCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error clearing recycle bag: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

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
        private void btnCartons_Click_1(object sender, EventArgs e)
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
    }
}