using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class UserSignUp1 : Form
    {
        private Main0 mainForm;

        public UserSignUp1(Main0 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void UserSignUp1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            tbxFullName.KeyDown += tbxFullName_KeyDown;

            cbxProvince.SelectedIndexChanged += cbxProvince_SelectedIndexChanged;
            cbxMunicipality.SelectedIndexChanged += cbxMunicipality_SelectedIndexChanged;

            LoadProvinces();
        }

        private void tbxFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbxPhoneNum.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            SaveUserInfo();

            if (this.ParentForm is Main0 functionalityForm)
            {
                var nextForm = new UserSignUp(functionalityForm);
                functionalityForm.LoadFormIntoPanel(nextForm);
            }// Pass ID to the next form
        }

        private void linkUserLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.ParentForm is Main0 functionalityForm)
            {
                functionalityForm.LoadFormIntoPanel(new UserLogIn());
            }
        }

        private void LoadProvinces()
        {
            try
            {
                cbxProvince.Items.Clear();
                string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb;";
                string query = "SELECT ProvinceName FROM Province";

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cbxProvince.Items.Add(reader["ProvinceName"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading provinces: " + ex.Message);
            }
        }

        private void cbxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxMunicipality.Items.Clear();
            cbxBarangay.Items.Clear();
            cbxMunicipality.Text = "";
            cbxBarangay.Text = "";

            string selectedProvince = cbxProvince.Text;

            try
            {
                string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb;";
                string query = "SELECT MunicipalityName FROM Municipality WHERE ProvinceName = '" + selectedProvince + "'";

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cbxMunicipality.Items.Add(reader["MunicipalityName"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading municipalities: " + ex.Message);
            }
        }

        private void cbxMunicipality_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxBarangay.Items.Clear();
            cbxBarangay.Text = "";

            string selectedMunicipality = cbxMunicipality.Text;

            try
            {
                string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb;";
                string query = "SELECT BarangayName FROM Barangay WHERE MunicipalityName = '" + selectedMunicipality + "'";

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cbxBarangay.Items.Add(reader["BarangayName"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading barangays: " + ex.Message);
            }
        }

        private int SaveUserInfo()
        {
            int userInfoID = -1;

            string query = "INSERT INTO UserInfos (FullName, PhoneNumber, Province, Municipality, Barangay) " +
                           "VALUES (?, ?, ?, ?, ?)";

            using (OleDbConnection conn = new OleDbConnection(
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maica eupinado\Documents\GreenCycleDatabase.accdb;"))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", tbxFullName.Text);
                cmd.Parameters.AddWithValue("?", tbxPhoneNum.Text);
                cmd.Parameters.AddWithValue("?", cbxProvince.Text);
                cmd.Parameters.AddWithValue("?", cbxMunicipality.Text);
                cmd.Parameters.AddWithValue("?", cbxBarangay.Text);
                cmd.ExecuteNonQuery();

                // Get the last inserted ID
                cmd = new OleDbCommand("SELECT @@IDENTITY", conn);
                userInfoID = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return userInfoID;
        }
    }
}
