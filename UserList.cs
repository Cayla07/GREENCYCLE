using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class UserList : Form
    {
        private AdminMain1 parentForm;
        private OleDbConnection? myConn;
        private OleDbDataAdapter? da;
        private DataSet? ds;
        private int indexRow;

        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb;";

        public UserList(AdminMain1 parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void MonitorUsers_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            tbxEmail.KeyDown += tbxEmail_KeyDown;
            tbxPassword.KeyDown += tbxPassword_KeyDown;
            tbxFullname.KeyDown += tbxFullname_KeyDown;
            tbxPhoneNum.KeyDown += tbxPhoneNum_KeyDown;

            cbxProvince.SelectedIndexChanged += cbxProvince_SelectedIndexChanged;
            cbxMunicipality.SelectedIndexChanged += cbxMunicipality_SelectedIndexChanged;

            LoadProvinces();
        }

        private void btnConnection_Click_1(object sender, EventArgs e)
        {
            try
            {
                myConn = new OleDbConnection(connString);
                myConn.Open();
                MessageBox.Show("Connected successfully!");
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }

        private void btnLoadFile_Click_1(object sender, EventArgs e)
        {
            try
            {
                myConn = new OleDbConnection(connString);
                da = new OleDbDataAdapter(
                    "SELECT UserAccount.ID, UserAccount.Email, UserAccount.Password, UserInfo.FullName, UserInfo.PhoneNumber, UserInfo.Province, UserInfo.Municipality, UserInfo.Barangay, UserInfo.Purok FROM UserAccount INNER JOIN UserInfo ON UserAccount.ID = UserInfo.ID;",
                    myConn);
                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "UserQuery");
                dgvUserList.DataSource = ds.Tables["UserQuery"];
                myConn.Close();
                dgvUserList.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void tbxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbxPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbxFullname.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void tbxFullname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbxPhoneNum.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void tbxPhoneNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbxProvince.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void LoadProvinces()
        {
            try
            {
                cbxProvince.Items.Clear();
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
            cbxPurok.Items.Clear();

            string selectedProvince = cbxProvince.Text;
            if (string.IsNullOrEmpty(selectedProvince)) return;

            try
            {
                string query = "SELECT MunicipalityName FROM Municipality WHERE ProvinceName = ?";

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", selectedProvince);
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
            cbxPurok.Items.Clear();

            string selectedMunicipality = cbxMunicipality.Text;
            if (string.IsNullOrEmpty(selectedMunicipality)) return;

            try
            {
                string query = "SELECT BarangayName FROM Barangay WHERE MunicipalityName = ?";

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", selectedMunicipality);
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

        private void cbxBarangay_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxPurok.Items.Clear();

            string selectedBarangay = cbxBarangay.Text;
            if (string.IsNullOrEmpty(selectedBarangay)) return;

            try
            {
                string query = "SELECT PurokName FROM Barangay WHERE BarangayName = ?";

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", selectedBarangay);
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cbxPurok.Items.Add(reader["PurokName"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading purok: " + ex.Message);
            }
        }

        private void cbxPurok_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProvince = cbxProvince.Text;
            string selectedMunicipality = cbxMunicipality.Text;
            string selectedBarangay = cbxBarangay.Text;
            string selectedPurok = cbxPurok.Text;

            if (string.IsNullOrWhiteSpace(selectedProvince) ||
                string.IsNullOrWhiteSpace(selectedMunicipality) ||
                string.IsNullOrWhiteSpace(selectedBarangay) ||
                string.IsNullOrWhiteSpace(selectedPurok))
                return;

            try
            {
                string query = "SELECT UserAccount.ID, UserAccount.Email, UserAccount.Password, " +
                               "UserInfo.FullName, UserInfo.PhoneNumber, " +
                               "UserInfo.Province, UserInfo.Municipality, UserInfo.Barangay, UserInfo.Purok " +
                               "FROM UserAccount INNER JOIN UserInfo ON UserAccount.ID = UserInfo.ID " +
                               "WHERE UserInfo.Province = ? AND UserInfo.Municipality = ? AND UserInfo.Barangay = ? AND UserInfo.Purok = ?";

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", selectedProvince);
                    cmd.Parameters.AddWithValue("?", selectedMunicipality);
                    cmd.Parameters.AddWithValue("?", selectedBarangay);
                    cmd.Parameters.AddWithValue("?", selectedPurok);

                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    DataSet filteredData = new DataSet();
                    adapter.Fill(filteredData, "FilteredUsers");

                    dgvUserList.DataSource = filteredData.Tables["FilteredUsers"];
                    dgvUserList.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering users: " + ex.Message);
            }
        }

        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUserList.Rows[e.RowIndex];
                tbxUserID.Text = row.Cells["ID"].Value?.ToString();
                tbxEmail.Text = row.Cells["Email"].Value?.ToString();
                tbxPassword.Text = row.Cells["Password"].Value?.ToString();
                tbxFullname.Text = row.Cells["FullName"].Value?.ToString();
                tbxPhoneNum.Text = row.Cells["PhoneNumber"].Value?.ToString();

                string province = row.Cells["Province"].Value?.ToString();
                string municipality = row.Cells["Municipality"].Value?.ToString();
                string barangay = row.Cells["Barangay"].Value?.ToString();
                string purok = row.Cells["Purok"].Value?.ToString();

                cbxProvince.SelectedItem = province;

                LoadMunicipalities(province);
                cbxMunicipality.SelectedItem = municipality;

                LoadBarangays(municipality);
                cbxBarangay.SelectedItem = barangay;

                cbxPurok.SelectedItem = purok;
            }
        }

        private void LoadMunicipalities(string province)
        {
            cbxMunicipality.Items.Clear();
            string query = "SELECT MunicipalityName FROM Municipality WHERE ProvinceName = ?";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", province);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbxMunicipality.Items.Add(reader["MunicipalityName"].ToString());
                }
            }
        }

        private void LoadBarangays(string municipality)
        {
            cbxBarangay.Items.Clear();
            string query = "SELECT BarangayName FROM Barangay WHERE MunicipalityName = ?";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", municipality);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbxBarangay.Items.Add(reader["BarangayName"].ToString());
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchID = tbxUserID.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchID))
            {
                return;
            }

            try
            {
                string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb;";
                string query = "SELECT UserAccount.ID, UserAccount.Email, UserAccount.Password, " +
                               "UserInfo.FullName, UserInfo.PhoneNumber, " +
                               "UserInfo.Province, UserInfo.Municipality, UserInfo.Barangay, UserInfo.Purok" +
                               "FROM UserAccount INNER JOIN UserInfo ON UserAccount.ID = UserInfo.ID " +
                               "WHERE UserAccount.ID = ?";

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", searchID);

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "UserSearch");

                        dgvUserList.DataSource = ds.Tables["UserSearch"];
                        dgvUserList.Columns["ID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching user: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            tbxUserID.Clear();
            tbxEmail.Clear();
            tbxPassword.Clear();
            tbxFullname.Clear();
            tbxPhoneNum.Clear();
            cbxProvince.SelectedIndex = -1;
            cbxMunicipality.Items.Clear();
            cbxBarangay.Items.Clear();
            cbxPurok.Items.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
