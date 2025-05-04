using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class Rewards : Form
    {
        private AdminMain1 parentForm;
        private OleDbConnection? myConn;
        private OleDbDataAdapter? da;
        private OleDbCommand? cmd;
        private DataSet? ds;
        private int indexRow;
        private const string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb";

        public Rewards(AdminMain1 parent)
        {
            InitializeComponent();
            this.parentForm = parent;

            tbxItemID.KeyDown += tbxItemID_KeyDown;
            btnSearch.Click += btnSearch_Click;
            btnInsert.Click += btnInsert_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void Rewards_Load(object sender, EventArgs e)
        {
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = new OleDbConnection(ConnectionString);
                conn.Open();
                MessageBox.Show("Connected successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }

        private void LoadRewards()
        {
            try
            {
                using var conn = new OleDbConnection(ConnectionString);
                conn.Open();

                da = new OleDbDataAdapter("SELECT * FROM Rewards", conn);
                ds = new DataSet();
                da.Fill(ds, "Rewards");

                dgvReward.DataSource = ds.Tables["Rewards"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message);
            }
        }

        private void SearchReward()
        {
            if (string.IsNullOrWhiteSpace(tbxItemID.Text))
            {
                MessageBox.Show("Please enter a Reward ID to search.");
                return;
            }

            try
            {
                using var conn = new OleDbConnection(ConnectionString);
                conn.Open();

                string query = "SELECT * FROM Rewards WHERE RewardID = @RewardID";
                using var cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@RewardID", tbxItemID.Text.Trim());

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tbxItem.Text = reader["Item"].ToString();
                    tbxPoints.Text = reader["EquivalentPoints"].ToString();
                }
                else
                {
                    MessageBox.Show("Reward not found.");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchReward();
        }

        private void tbxItemID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchReward();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void ClearFields()
        {
            tbxItemID.Text = string.Empty;
            tbxItem.Text = string.Empty;
            tbxPoints.Text = string.Empty;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            LoadRewards();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxItemID.Text) || string.IsNullOrWhiteSpace(tbxItem.Text) || string.IsNullOrWhiteSpace(tbxPoints.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using var conn = new OleDbConnection(ConnectionString);
                conn.Open();
                string query = "INSERT INTO Rewards (RewardID, Item, EquivalentPoints) VALUES (?, ?, ?)";
                using var cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", tbxItemID.Text.Trim());
                cmd.Parameters.AddWithValue("?", tbxItem.Text.Trim());
                cmd.Parameters.AddWithValue("?", tbxPoints.Text.Trim());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Reward inserted successfully.");
                LoadRewards();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxItemID.Text))
            {
                MessageBox.Show("Please enter the Reward ID to update.");
                return;
            }

            try
            {
                using var conn = new OleDbConnection(ConnectionString);
                conn.Open();
                string query = "UPDATE Rewards SET Item = ?, EquivalentPoints = ? WHERE RewardID = ?";
                using var cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", tbxItem.Text.Trim());
                cmd.Parameters.AddWithValue("?", tbxPoints.Text.Trim());
                cmd.Parameters.AddWithValue("?", tbxItemID.Text.Trim());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Reward updated successfully.");
                LoadRewards();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxItemID.Text))
            {
                MessageBox.Show("Please enter the Reward ID to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this reward?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using var conn = new OleDbConnection(ConnectionString);
                conn.Open();
                string query = "DELETE FROM Rewards WHERE RewardID = ?";
                using var cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", tbxItemID.Text.Trim());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Reward deleted successfully.");
                LoadRewards();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void dgvReward_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvReward.Rows[e.RowIndex];
                tbxItemID.Text = row.Cells["RewardID"].Value.ToString();
                tbxItem.Text = row.Cells["Item"].Value.ToString();
                tbxPoints.Text = row.Cells["EquivalentPoints"].Value.ToString();
            }
        }
    }
}
