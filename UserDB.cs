using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class UserDB : Form
    {
        private UserMain1 parentForm;
        private const string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb";

        public UserDB(UserMain1 parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void UserDB_Load(object sender, EventArgs e)
        {
            LoadAllRewards();

        }
        private void LoadAllRewards()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Rewards ORDER BY EquivalentPoints ASC";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanel1.Controls.Clear();

                        while (reader.Read())
                        {
                            string item = reader["Item"].ToString();
                            int points = Convert.ToInt32(reader["EquivalentPoints"]);

                            Panel rewardPanel = new Panel
                            {
                                Width = 280,
                                Height = 50,
                                BackColor = Color.LightBlue,
                                Margin = new Padding(5),
                                BorderStyle = BorderStyle.FixedSingle
                            };

                            Label lbl = new Label
                            {
                                Text = item + " - " + points + " pts",
                                Font = new Font("Segoe UI", 10),
                                Dock = DockStyle.Fill,
                                TextAlign = ContentAlignment.MiddleLeft,
                                Padding = new Padding(10, 15, 0, 0),
                                ForeColor = Color.Black
                            };

                            rewardPanel.Controls.Add(lbl);
                            flowLayoutPanel1.Controls.Add(rewardPanel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rewards: " + ex.Message);
            }
        }
    }
}

