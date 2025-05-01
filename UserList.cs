using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class UserList : Form
    {
        private readonly AdminMain1 parentForm;
        private OleDbConnection? myConn;
        private OleDbDataAdapter? da;
        private OleDbCommand? cmd;
        private DataSet? ds;
        private int indexRow;

        private const string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb";

        public UserList(AdminMain1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void UserList_Load_1(object sender, EventArgs e)
        {
            KeyPreview = true;
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
                using var conn = new OleDbConnection(ConnectionString);
                conn.Open();
                MessageBox.Show("Connected successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }

        private void btnLoadFile_Click_1(object sender, EventArgs e)
        {
            string query = @"
                SELECT UserAccounts.AccountID, UserAccounts.Email, UserAccounts.Password,
                       UserInfos.FullName, UserInfos.PhoneNumber, UserInfos.Province,
                       UserInfos.Municipality, UserInfos.Barangay
                FROM UserInfos
                INNER JOIN UserAccounts ON UserInfos.UserInfosID = UserAccounts.AccountID";

            ds = new DataSet();

            try
            {
                using var conn = new OleDbConnection(ConnectionString);
                da = new OleDbDataAdapter(query, conn);
                conn.Open();
                da.Fill(ds, "UserQuery");
                dgvUserList.DataSource = ds.Tables["UserQuery"];
                dgvUserList.Columns["AccountID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            cbxProvince.Items.Clear();
            try
            {
                using var conn = new OleDbConnection(ConnectionString);
                conn.Open();
                using var cmd = new OleDbCommand("SELECT ProvinceName FROM Province", conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbxProvince.Items.Add(reader["ProvinceName"].ToString());
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
                using var conn = new OleDbConnection(ConnectionString);
                conn.Open();
                using var cmd = new OleDbCommand("SELECT MunicipalityName FROM Municipality WHERE ProvinceName = ?", conn);
                cmd.Parameters.AddWithValue("?", selectedProvince);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbxMunicipality.Items.Add(reader["MunicipalityName"].ToString());
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
                using var conn = new OleDbConnection(ConnectionString);
                conn.Open();
                using var cmd = new OleDbCommand("SELECT BarangayName FROM Barangay WHERE MunicipalityName = ?", conn);
                cmd.Parameters.AddWithValue("?", selectedMunicipality);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbxBarangay.Items.Add(reader["BarangayName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading barangays: " + ex.Message);
            }
        }

        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvUserList.Rows[e.RowIndex];

            tbxUserID.Text = row.Cells["AccountID"].Value?.ToString();
            tbxEmail.Text = row.Cells["Email"].Value?.ToString();
            tbxPassword.Text = row.Cells["Password"].Value?.ToString();
            tbxFullname.Text = row.Cells["FullName"].Value?.ToString();
            tbxPhoneNum.Text = row.Cells["PhoneNumber"].Value?.ToString();

            string province = row.Cells["Province"].Value?.ToString();
            string municipality = row.Cells["Municipality"].Value?.ToString();
            string barangay = row.Cells["Barangay"].Value?.ToString();

            cbxProvince.SelectedItem = province;

            if (!string.IsNullOrWhiteSpace(province))
                LoadMunicipalities(province, municipality);

            if (!string.IsNullOrWhiteSpace(municipality))
                LoadBarangays(municipality, barangay);

            indexRow = e.RowIndex;
        }

        private void LoadMunicipalities(string province, string? select = null)
        {
            cbxMunicipality.Items.Clear();
            using var conn = new OleDbConnection(ConnectionString);
            conn.Open();
            using var cmd = new OleDbCommand("SELECT MunicipalityName FROM Municipality WHERE ProvinceName = ?", conn);
            cmd.Parameters.AddWithValue("?", province);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["MunicipalityName"].ToString();
                cbxMunicipality.Items.Add(name);
            }
            cbxMunicipality.SelectedItem = select;
        }

        private void LoadBarangays(string municipality, string? select = null)
        {
            cbxBarangay.Items.Clear();
            using var conn = new OleDbConnection(ConnectionString);
            conn.Open();
            using var cmd = new OleDbCommand("SELECT BarangayName FROM Barangay WHERE MunicipalityName = ?", conn);
            cmd.Parameters.AddWithValue("?", municipality);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["BarangayName"].ToString();
                cbxBarangay.Items.Add(name);
            }
            cbxBarangay.SelectedItem = select;
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void cbxBarangay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxProvince.Text) ||
                string.IsNullOrWhiteSpace(cbxMunicipality.Text) ||
                string.IsNullOrWhiteSpace(cbxBarangay.Text)) return;

            try
            {
                using var conn = new OleDbConnection(ConnectionString);
                string query = @"
                    SELECT UserAccounts.AccountID, UserAccounts.Email, UserAccounts.Password,
                           UserInfos.FullName, UserInfos.PhoneNumber,
                           UserInfos.Province, UserInfos.Municipality, UserInfos.Barangay
                    FROM UserAccounts
                    INNER JOIN UserInfos ON UserAccounts.AccountID = UserInfos.UserInfosID
                    WHERE UserInfos.Province = ? AND UserInfos.Municipality = ? AND UserInfos.Barangay = ?";

                using var cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", cbxProvince.Text);
                cmd.Parameters.AddWithValue("?", cbxMunicipality.Text);
                cmd.Parameters.AddWithValue("?", cbxBarangay.Text);

                var adapter = new OleDbDataAdapter(cmd);
                var filteredData = new DataSet();
                adapter.Fill(filteredData, "FilteredUsers");

                dgvUserList.DataSource = filteredData.Tables["FilteredUsers"];
                dgvUserList.Columns["AccountID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering users: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxUserID.Text)) return;

            try
            {
                using var conn = new OleDbConnection(ConnectionString);
                string query = @"
                    SELECT UserAccounts.AccountID, UserAccounts.Email, UserAccounts.Password,
                           UserInfos.FullName, UserInfos.PhoneNumber,
                           UserInfos.Province, UserInfos.Municipality, UserInfos.Barangay
                    FROM UserAccounts
                    INNER JOIN UserInfos ON UserAccounts.AccountID = UserInfos.UserInfosID
                    WHERE UserAccounts.AccountID = ?";

                using var cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", tbxUserID.Text);

                var adapter = new OleDbDataAdapter(cmd);
                var ds = new DataSet();
                adapter.Fill(ds, "UserSearch");

                dgvUserList.DataSource = ds.Tables["UserSearch"];
                dgvUserList.Columns["AccountID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching user: " + ex.Message);
            }
        }
    }
}
