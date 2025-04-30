using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class History : Form
    {
        private UserMain1 parentForm;
        private OleDbConnection connection;
        private string userEmail; // Save the email of the logged-in user

        public History(string email, UserMain1 parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            userEmail = email;
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb;");
        }

        private void History_Load(object sender, EventArgs e)
        {
            LoadRecycleHistory();
        }

        private void LoadRecycleHistory()
        {
            try
            {
                connection.Open();
                string query = "SELECT RecycleActivities.ActivityDate, Recycles.MaterialName, " +
                    "Recycles.Weight, Recycles.Points " + "FROM (UserAccount INNER JOIN RecycleActivities ON UserAccount.AccountID = RecycleActivities.AccountID) " +
               "INNER JOIN Recycles ON RecycleActivities.ActivityID = Recycles.ActivityID " +
               "WHERE UserAccount.Email = '" + userEmail + "' " +
               "ORDER BY RecycleActivities.ActivityDate DESC";


                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Create and set up a DataGridView
                DataGridView dgvHistory = new DataGridView();
                dgvHistory.DataSource = dt;
                dgvHistory.Dock = DockStyle.Fill;
                dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHistory.ReadOnly = true;
                dgvHistory.AllowUserToAddRows = false;
                dgvHistory.RowHeadersVisible = false;
                this.Controls.Add(dgvHistory);

                // Optionally: Calculate Total Points
                int totalPoints = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["PointsEarned"] != DBNull.Value)
                    {
                        totalPoints += Convert.ToInt32(row["PointsEarned"]);
                    }
                }

                // Create and show Total Points label
                Label lblTotalPoints = new Label();
                lblTotalPoints.Text = "Total Points: " + totalPoints.ToString();
                lblTotalPoints.Dock = DockStyle.Bottom;
                lblTotalPoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                lblTotalPoints.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
                this.Controls.Add(lblTotalPoints);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recycle history: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
