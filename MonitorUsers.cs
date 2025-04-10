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
    public partial class MonitorUsers : Form
    {
        private AdminMain1 parentForm;

        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public MonitorUsers(AdminMain1 parent)
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
            tbxAge.KeyDown += tbxAge_KeyDown;
            tbxPhoneNum.KeyDown += tbxPhoneNum_KeyDown;

            cbxProvince.SelectedIndexChanged += cbxProvince_SelectedIndexChanged;
            cbxMunicipality.SelectedIndexChanged += cbxMunicipality_SelectedIndexChanged;

            LoadProvinces();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb");
            ds = new DataSet();
            myConn.Open();
            MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb");
            da = new OleDbDataAdapter(
                "SELECT UserAccount.ID, UserAccount.Email, UserAccount.Password, UserInfo.FullName, UserInfo.Age, UserInfo.PhoneNumber, UserInfo.Province, UserInfo.Municipality, UserInfo.Barangay FROM UserAccount INNER JOIN UserInfo ON UserAccount.ID = UserInfo.ID;",
                myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "UserQuery");
            dataGridView1.DataSource = ds.Tables["UserQuery"];
            myConn.Close();

            dataGridView1.Columns["ID"].Visible = false;
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
                tbxAge.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void tbxAge_KeyDown(object sender, KeyEventArgs e)
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb");
                myConn.Open();

                string queryAccount = "INSERT INTO UserAccount (Email, [Password]) VALUES (?, ?)";
                cmd = new OleDbCommand(queryAccount, myConn);
                cmd.Parameters.AddWithValue("?", tbxEmail.Text);
                cmd.Parameters.AddWithValue("?", tbxPassword.Text);
                cmd.ExecuteNonQuery();

                string getIdQuery = "SELECT MAX(ID) FROM UserAccount";
                cmd = new OleDbCommand(getIdQuery, myConn);
                int userId = Convert.ToInt32(cmd.ExecuteScalar());

                string queryInfo = "INSERT INTO UserInfo (ID, FullName, Age, PhoneNumber, Province, Municipality, Barangay) VALUES (?, ?, ?, ?, ?, ?, ?)";
                cmd = new OleDbCommand(queryInfo, myConn);
                cmd.Parameters.AddWithValue("?", userId);
                cmd.Parameters.AddWithValue("?", tbxFullname.Text);
                cmd.Parameters.AddWithValue("?", tbxAge.Text);
                cmd.Parameters.AddWithValue("?", tbxPhoneNum.Text);
                cmd.Parameters.AddWithValue("?", cbxProvince.Text);
                cmd.Parameters.AddWithValue("?", cbxMunicipality.Text);
                cmd.Parameters.AddWithValue("?", cbxBarangay.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("User inserted successfully!");
                myConn.Close();

                btnLoadFile.PerformClick();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting user: " + ex.Message);
                if (myConn != null && myConn.State == ConnectionState.Open)
                    myConn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxUserID.Text))
                    return;

                int userId = int.Parse(tbxUserID.Text);
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb");
                myConn.Open();

                // Delete from UserInfo first
                string deleteUserInfo = "DELETE FROM UserInfo WHERE ID = ?";
                cmd = new OleDbCommand(deleteUserInfo, myConn);
                cmd.Parameters.AddWithValue("?", userId);
                cmd.ExecuteNonQuery();

                // Then delete from UserAccount
                string deleteUserAccount = "DELETE FROM UserAccount WHERE ID = ?";
                cmd = new OleDbCommand(deleteUserAccount, myConn);
                cmd.Parameters.AddWithValue("?", userId);
                cmd.ExecuteNonQuery();

                myConn.Close();
                MessageBox.Show("User deleted successfully!");
                btnLoadFile.PerformClick();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message);
                if (myConn != null && myConn.State == ConnectionState.Open)
                    myConn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxUserID.Text))
                    return;

                int userId = int.Parse(tbxUserID.Text);
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maica eupinado\\Documents\\GreenCycleDatabase.accdb");
                myConn.Open();

                // --- First update: UserAccount ---
                string updateAccount = "UPDATE UserAccount SET Email = ?, [Password] = ? WHERE ID = ?";
                cmd = new OleDbCommand(updateAccount, myConn);
                cmd.Parameters.AddWithValue("?", tbxEmail.Text);
                cmd.Parameters.AddWithValue("?", tbxPassword.Text);
                cmd.Parameters.AddWithValue("?", userId);
                cmd.ExecuteNonQuery();

                // --- Second update: UserInfo ---
                string updateInfo = "UPDATE UserInfo SET FullName = ?, Age = ?, PhoneNumber = ?, " +
                                    "Province = ?, Municipality = ?, Barangay = ? WHERE ID = ?";
                cmd = new OleDbCommand(updateInfo, myConn);
                cmd.Parameters.AddWithValue("?", tbxFullname.Text);
                cmd.Parameters.AddWithValue("?", tbxAge.Text);
                cmd.Parameters.AddWithValue("?", tbxPhoneNum.Text);
                cmd.Parameters.AddWithValue("?", cbxProvince.Text);
                cmd.Parameters.AddWithValue("?", cbxMunicipality.Text);
                cmd.Parameters.AddWithValue("?", cbxBarangay.Text);
                cmd.Parameters.AddWithValue("?", userId);
                cmd.ExecuteNonQuery();

                myConn.Close();
                MessageBox.Show("User updated successfully!");
                btnLoadFile.PerformClick();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
                if (myConn != null && myConn.State == ConnectionState.Open)
                    myConn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // ✅ Set UserID
                tbxUserID.Text = row.Cells["ID"].Value?.ToString();

                // Other fields
                tbxEmail.Text = row.Cells["Email"].Value?.ToString();
                tbxPassword.Text = row.Cells["Password"].Value?.ToString();
                tbxFullname.Text = row.Cells["FullName"].Value?.ToString();
                tbxAge.Text = row.Cells["Age"].Value?.ToString();
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
            tbxAge.Clear();
            tbxPhoneNum.Clear();
            cbxProvince.SelectedIndex = -1;
            cbxMunicipality.Items.Clear();
            cbxBarangay.Items.Clear();
        }
    }
}
