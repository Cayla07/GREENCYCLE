using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class Statistics : Form
    {
        private AdminMain1 parentForm;
        private PlotView plotView; 
        private ComboBox municipalityComboBox; 

        public Statistics(AdminMain1 parent)
        {
            InitializeComponent();
            this.parentForm = parent;

            municipalityComboBox = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList, 
                Location = new Point(10, 10), 
                Width = 200 
            };
            municipalityComboBox.SelectedIndexChanged += MunicipalityComboBox_SelectedIndexChanged; 
            flowLayoutPanel1.Controls.Add(municipalityComboBox); 

            plotView = new PlotView
            {
                Width = flowLayoutPanel1.Width - 20,
                Height = 400,
                Dock = DockStyle.Top,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            flowLayoutPanel1.Controls.Add(plotView); 

            LoadMunicipalities(); 
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadMunicipalities()
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb";
            string query = "SELECT DISTINCT Municipality FROM UserInfos ORDER BY Municipality"; 

            List<string> municipalities = new List<string>();
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                using (OleDbCommand command = new OleDbCommand(query, conn))
                {
                    conn.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            municipalities.Add(reader["Municipality"].ToString());
                        }
                    }
                }
                municipalityComboBox.Items.Clear();
                municipalityComboBox.Items.AddRange(municipalities.ToArray());
                if (municipalityComboBox.Items.Count > 0)
                {
                    municipalityComboBox.SelectedIndex = 0; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading municipalities: " + ex.Message);
            }
        }

        private Dictionary<string, int> GetUsersPerBarangay(string selectedMunicipality)
        {
            Dictionary<string, int> barangayCounts = new Dictionary<string, int>();
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb";
            string query = @"SELECT UserInfos.Barangay
                        FROM UserInfos INNER JOIN UserAccounts 
                        ON UserInfos.UserInfosID = UserAccounts.AccountID
                        WHERE UserInfos.Municipality = @Municipality";

            using (OleDbConnection conn = new OleDbConnection(connString))
            using (OleDbCommand command = new OleDbCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Municipality", selectedMunicipality); 
                conn.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string barangay = reader["Barangay"].ToString();
                        if (barangayCounts.ContainsKey(barangay))
                            barangayCounts[barangay]++;
                        else
                            barangayCounts[barangay] = 1;
                    }
                }
            }
            return barangayCounts;
        }

        private void MunicipalityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (municipalityComboBox.SelectedItem != null)
            {
                string selectedMunicipality = municipalityComboBox.SelectedItem.ToString();
                CreateUsersPerBarangayGraph(selectedMunicipality); 
            }
        }

        private void CreateUsersPerBarangayGraph(string selectedMunicipality)
        {
            var usersPerBarangay = GetUsersPerBarangay(selectedMunicipality);
            var sorted = usersPerBarangay.OrderBy(x => x.Key).ToList();

            var model = new PlotModel { Title = $"Users per Barangay in {selectedMunicipality}" };  

            var barSeries = new BarSeries
            {
                ItemsSource = sorted.Select(x => new BarItem { Value = x.Value }).ToList(),
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}"
            };

            model.Series.Add(barSeries);

            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                ItemsSource = sorted.Select(x => x.Key).ToList()
            });

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                MinimumPadding = 0,
                AbsoluteMinimum = 0, 
                Title = "Number of Users",  
                MajorStep = 1, 
                MinorStep = 1,
                StringFormat = "0" 
            });

            plotView.Model = model; 
            plotView.InvalidatePlot(true); 
        }

        private void plotView2_Click(object sender, EventArgs e)
        {

        }
    }
}
