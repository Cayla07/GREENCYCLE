using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GREENCYCLE
{
    public partial class Receipt : Form
    {
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maica eupinado\Documents\GreenCycleDatabase.accdb;Persist Security Info=False;";
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
            panelReceipt.Controls.Clear();
            panelReceipt.FlowDirection = FlowDirection.TopDown;
            panelReceipt.WrapContents = false;
            panelReceipt.AutoScroll = true;

            foreach (var item in RecycleBag)
            {
                Panel materialPanel = new Panel
                {
                    Size = new Size(panelReceipt.ClientSize.Width - 10, 30),
                    BackColor = Color.Transparent,
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
                    Text = $"{item.Value:F2} kg",
                    AutoSize = false,
                    Size = new Size(95, 25),
                    Location = new Point(243, 8),
                    Font = new Font("Arial Rounded MT", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                double points = (double)(item.Value * (MaterialPointMultipliers.ContainsKey(item.Key) ? MaterialPointMultipliers[item.Key] : 10));
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
            // Implement PDF generation logic here if needed
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            SaveSubmissionToHistory(Email, TotalPoints, GetSubmissionDetails());
            this.Close();
        }

        private string GetSubmissionDetails()
        {
            string details = "";
            foreach (var item in RecycleBag)
            {
                details += $"{item.Value} kg {item.Key}, ";
            }
            if (details.EndsWith(", "))
            {
                details = details.Substring(0, details.Length - 2);
            }
            return details;
        }

        private void SaveSubmissionToHistory(string email, double totalPoints, string details)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO RecycleHistory (Email, SubmissionDate, TotalPoints, Details) VALUES (@Email, @SubmissionDate, @TotalPoints, @Details)";
                    OleDbCommand command = new OleDbCommand(query, connection);

                    command.Parameters.Add("@Email", OleDbType.VarWChar).Value = email;
                    command.Parameters.Add("@SubmissionDate", OleDbType.DBDate).Value = DateTime.Now.Date; // Use DBDate if you only need the date
                    command.Parameters.Add("@TotalPoints", OleDbType.Double).Value = totalPoints;
                    command.Parameters.Add("@Details", OleDbType.LongVarWChar).Value = details;

                    command.ExecuteNonQuery();
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"Error saving to history: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}