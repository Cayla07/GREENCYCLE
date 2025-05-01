using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class History : Form
    {
        private UserMain1 parentForm;
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maica eupinado\Documents\GreenCycleDatabase.accdb;Persist Security Info=False;";
        private string userEmail;

        public History(string email, UserMain1 parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            userEmail = email;
            LoadHistory();
        }

        private void LoadHistory()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT SubmissionDate, TotalPoints, Details FROM RecycleHistory WHERE Email = ? ORDER BY SubmissionDate DESC";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("?", userEmail);

                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    System.Data.DataTable historyTable = new System.Data.DataTable();
                    adapter.Fill(historyTable);

                    dgvHistory.DataSource = historyTable;

                    // Optional: Customize column headers
                    if (dgvHistory.Columns.Contains("SubmissionDate"))
                        dgvHistory.Columns["SubmissionDate"].HeaderText = "Submission Date";
                    if (dgvHistory.Columns.Contains("TotalPoints"))
                        dgvHistory.Columns["TotalPoints"].HeaderText = "Total Points";
                    if (dgvHistory.Columns.Contains("Details"))
                        dgvHistory.Columns["Details"].HeaderText = "Items Submitted";
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"Error loading history: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}