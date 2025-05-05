using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
            MaterialPointMultipliers = materialPointMultipliers ?? new Dictionary<string, double>(); // Initialize if null

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
                    Font = new System.Drawing.Font("Arial Rounded MT", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleLeft
                };

                Label lblWeight = new Label
                {
                    Text = $"{item.Value:F2} kg",
                    AutoSize = false,
                    Size = new Size(95, 25),
                    Location = new Point(243, 8),
                    Font = new System.Drawing.Font("Arial Rounded MT", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                double points = item.Value * (MaterialPointMultipliers.ContainsKey(item.Key) ? MaterialPointMultipliers[item.Key] : 10);
                Label lblPoints = new Label
                {
                    Text = $"{points:F1}",
                    AutoSize = false,
                    Size = new Size(50, 25),
                    Location = new Point(483, 7),
                    Font = new System.Drawing.Font("Arial Rounded MT", 10, FontStyle.Bold),
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
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save Receipt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document doc = new Document(PageSize.A6, 10, 10, 10, 10);
                    PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    doc.Open();

                    // Set fonts
                    BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font normalFont = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.NORMAL);
                    iTextSharp.text.Font boldFont = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.BOLD);

                    // Header - GREENCYCLE
                    Paragraph header = new Paragraph("GREENCYCLE", boldFont);
                    header.Alignment = Element.ALIGN_CENTER;
                    doc.Add(header);
                    doc.Add(new Paragraph("\n"));

                    // User Information
                    doc.Add(new Paragraph($"Email: {Email}", normalFont));
                    doc.Add(new Paragraph($"Date: {DateTime.Now:yyyy-MM-dd HH:mm}", normalFont));
                    doc.Add(new Paragraph("\n"));

                    // Items Table
                    PdfPTable table = new PdfPTable(3);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[] { 3f, 1.5f, 1f }); // Adjust column widths

                    // Table Headers
                    PdfPCell headerCell1 = new PdfPCell(new Phrase("Material", boldFont));
                    PdfPCell headerCell2 = new PdfPCell(new Phrase("Weight", boldFont));
                    PdfPCell headerCell3 = new PdfPCell(new Phrase("Point", boldFont));
                    table.AddCell(headerCell1);
                    table.AddCell(headerCell2);
                    table.AddCell(headerCell3);
                    table.HeaderRows = 1;

                    // Add items from RecycleBag
                    foreach (var item in RecycleBag)
                    {
                        double points = item.Value * (MaterialPointMultipliers.ContainsKey(item.Key) ? MaterialPointMultipliers[item.Key] : 10);
                        table.AddCell(new Phrase(item.Key, normalFont));
                        table.AddCell(new Phrase($"{item.Value:F2} kg", normalFont));
                        table.AddCell(new Phrase($"{points:F1}", normalFont));
                    }

                    doc.Add(table);
                    doc.Add(new Paragraph("\n"));

                    // Total Points
                    Paragraph totalPointsLabel = new Paragraph($"Total Points: {TotalPoints:F1}", boldFont);
                    totalPointsLabel.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(totalPointsLabel);

                    doc.Add(new Paragraph("\nThank you for recycling with GreenCycle!", normalFont) { Alignment = Element.ALIGN_CENTER });

                    doc.Close();

                    MessageBox.Show("Receipt generated successfully.", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to generate receipt: " + ex.Message);
                }
            }
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