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
    public partial class UserList : Form
    {
        private AdminMain1 parentForm;

        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        public UserList(AdminMain1 parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void UserList_Load_1(object sender, EventArgs e)
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
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb");
            ds = new DataSet();
            myConn.Open();
            MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        private void btnLoadFile_Click_1(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb");
            da = new OleDbDataAdapter(
                "SELECT UserAccount.ID, UserAccount.Email, UserAccount.Password, UserInfo.FullName, UserInfo.PhoneNumber, UserInfo.Province, UserInfo.Municipality, UserInfo.Barangay FROM UserAccount INNER JOIN UserInfo ON UserAccount.ID = UserInfo.ID;",
                myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "UserQuery");
            dgvUserList.DataSource = ds.Tables["UserQuery"];
            myConn.Close();

            dgvUserList.Columns["ID"].Visible = false;
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
            cbxBarangay.Text = "";

            string selectedMunicipality = cbxMunicipality.Text;

            try
            {
                string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb;";
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

        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUserList.Rows[e.RowIndex];

                // ✅ Set UserID
                tbxUserID.Text = row.Cells["ID"].Value?.ToString();

                // Other fields
                tbxEmail.Text = row.Cells["Email"].Value?.ToString();
                tbxPassword.Text = row.Cells["Password"].Value?.ToString();
                tbxFullname.Text = row.Cells["FullName"].Value?.ToString();
                tbxPhoneNum.Text = row.Cells["PhoneNumber"].Value?.ToString();

                string province = row.Cells["Province"].Value?.ToString();
                string municipality = row.Cells["Municipality"].Value?.ToString();
                string barangay = row.Cells["Barangay"].Value?.ToString();

                cbxProvince.SelectedItem = province;

                // Load Municipality
                if (!string.IsNullOrWhiteSpace(province))
                {
                    cbxMunicipality.Items.Clear();
                    string queryMunicipality = "SELECT MunicipalityName FROM Municipality WHERE ProvinceName = @Province";

                    using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb"))
                    {
                        conn.Open();
                        using (OleDbCommand cmd = new OleDbCommand(queryMunicipality, conn))
                        {
                            cmd.Parameters.AddWithValue("@Province", province);
                            OleDbDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                cbxMunicipality.Items.Add(reader["MunicipalityName"].ToString());
                            }
                        }
                    }

                    cbxMunicipality.SelectedItem = municipality;
                }

                // Load Barangay
                if (!string.IsNullOrWhiteSpace(municipality))
                {
                    cbxBarangay.Items.Clear();
                    string queryBarangay = "SELECT BarangayName FROM Barangay WHERE MunicipalityName = @Municipality";

                    using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb"))
                    {
                        conn.Open();
                        using (OleDbCommand cmd = new OleDbCommand(queryBarangay, conn))
                        {
                            cmd.Parameters.AddWithValue("@Municipality", municipality);
                            OleDbDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                cbxBarangay.Items.Add(reader["BarangayName"].ToString());
                            }
                        }
                    }

                    cbxBarangay.SelectedItem = barangay;
                }

                indexRow = e.RowIndex;
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void cbxBarangay_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProvince = cbxProvince.Text;
            string selectedMunicipality = cbxMunicipality.Text;
            string selectedBarangay = cbxBarangay.Text;

            if (string.IsNullOrWhiteSpace(selectedProvince) ||
                string.IsNullOrWhiteSpace(selectedMunicipality) ||
                string.IsNullOrWhiteSpace(selectedBarangay))
                return;

            try
            {
                string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb;";
                string query = "SELECT UserAccount.ID, UserAccount.Email, UserAccount.Password, " +
                               "UserInfo.FullName, UserInfo.PhoneNumber, " +
                               "UserInfo.Province, UserInfo.Municipality, UserInfo.Barangay " +
                               "FROM UserAccount INNER JOIN UserInfo ON UserAccount.ID = UserInfo.ID " +
                               "WHERE UserInfo.Province = ? AND UserInfo.Municipality = ? AND UserInfo.Barangay = ?";

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", selectedProvince);
                        cmd.Parameters.AddWithValue("?", selectedMunicipality);
                        cmd.Parameters.AddWithValue("?", selectedBarangay);

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataSet filteredData = new DataSet();
                        adapter.Fill(filteredData, "FilteredUsers");

                        dgvUserList.DataSource = filteredData.Tables["FilteredUsers"];
                        dgvUserList.Columns["ID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering users: " + ex.Message);
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
                               "UserInfo.Province, UserInfo.Municipality, UserInfo.Barangay " +
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

        private void cbxProvince_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}