using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.Data.SqlClient;


namespace MSSQL.View
{
    public partial class MSSQLViewerForm : Form
    {
        const string userRoot = "HKEY_CURRENT_USER\\SOFTWARE";
        const string subkey = "MSSQL.View";
        const string keyName = userRoot + "\\" + subkey;
        public DatabaseSettings AllDatabaseSettings = new DatabaseSettings();

        public SqlConnection SQLConn     = new SqlConnection();
        public SqlCommand SQLCmd         = new SqlCommand();
        public SqlDataAdapter SQLAdapter = new SqlDataAdapter();
        public DataTable SQLTable        = new DataTable();

        public interface IDatabaseSettings
        {
            //IEnumerable<DatabaseSettings> GetAllDatabaseSetting();
            void SaveDatabaseSetting(DatabaseSetting DBSet);
            void DeleteDatabaseSetting(DatabaseSetting DBSet);
        }

        public class DatabaseSettings: IDatabaseSettings
        {
            public IList<DatabaseSetting> DBList = new List<DatabaseSetting>(); // создали список из настроек
            //public IEnumerable<DatabaseSettings> GetAllDatabaseSetting() => DBList; // Список всех настроек
            public void SaveDatabaseSetting(DatabaseSetting DBSet) // записываем одну настройку
            {
                this.DBList.Add(DBSet);
            }
            public void DeleteDatabaseSetting(DatabaseSetting DBSet) // записываем одну настройку
            {
                this.DBList.Remove(DBSet);
            }
        }

        public class DatabaseSetting
        {
            public string SettingName { get; set; }
            public string MSSQLName { get; set; }
            public bool MSSQLWInAuth { get; set; }
            public string MSSQLLogin { get; set; }
            public string MSSQLPass { get; set; }
            public string Query { get; set; }
            public bool LastUsed { get; set; }
            public int Update { get; set; }
        }

        public void SaveIntoReg()
        {
            string RegData = JsonConvert.SerializeObject(this.AllDatabaseSettings);
            Registry.SetValue(keyName, "", RegData);
        }

        public void ReadFromReg()
        {
            string RegData = "";
            RegData = Registry.GetValue(keyName, "", null).ToString();
            DatabaseSettings AllDatabaseSettings = JsonConvert.DeserializeObject<DatabaseSettings>(RegData);
            this.AllDatabaseSettings = AllDatabaseSettings;
        }

        public void FirstFillData()
        {
            foreach (DatabaseSetting DB in this.AllDatabaseSettings.DBList)
            {
                this.ProfileComboBox.Items.Add(DB.SettingName);
                this.MSSQLServerNameComboBox.Items.Add(DB.MSSQLName);

                if (DB.LastUsed == true)
                {
                    this.ProfileComboBox.Text = DB.SettingName;
                    this.MSSQLServerNameComboBox.Text = DB.MSSQLName;
                    this.WinAuthCheckBox.Checked = DB.MSSQLWInAuth;
                    this.MSSQLLogin.Text = DB.MSSQLLogin;
                    this.MSSQLPass.Text = DB.MSSQLPass;
                    this.QueryTextBox.Text = DB.Query;
                    this.QueryUpdateTime.Text = DB.Update.ToString();
                    this.QueryUpdateTime.Text = DB.Update.ToString();
                    this.QueryTimerTextBox.Text = DB.Update.ToString();
                }
            }
        }

        public DatabaseSetting FindDBSetting(string ProfileName)
        {
            foreach (DatabaseSetting DB in this.AllDatabaseSettings.DBList)
            {
                if (DB.SettingName == ProfileName)
                    return DB;
            }
            return null;
        }
        
        public MSSQLViewerForm()
        {
            InitializeComponent();
        }

        private void MSSQLViewerForm_Load(object sender, EventArgs e)
        {
            ReadFromReg();
            FirstFillData();
            this.SQLDataGridView.AutoGenerateColumns = true;
        }

        private void QueryTimerTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void QueryTimerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.QueryTimer.Interval = Convert.ToInt32(this.QueryTimerTextBox.Text, 10) * 1000;
                this.QueryUpdateTime.Text = this.QueryTimerTextBox.Text;
                ProfileSaveButton_Click(this.ProfileComboBox, null);
                UpdateMSSQLQuery();
                this.SQLDataGridView.Focus();
            }
        }

        private void ProfileSaveButton_Click(object sender, EventArgs e)
        {
            if (this.ProfileComboBox.Text.Length > 0)
            {

            }
            else if ((this.ProfileComboBox.Text.Length == 0) && (this.MSSQLServerNameComboBox.Text.Length > 0))
            {
                DateTime localDate = DateTime.Now;
                this.ProfileComboBox.Text = this.MSSQLServerNameComboBox.Text + "-" + localDate.ToShortDateString();
            }
            else
            {
                DateTime localDate = DateTime.Now;
                this.ProfileComboBox.Text = "Default-" + localDate.ToShortDateString();
            }

            foreach (DatabaseSetting DB in this.AllDatabaseSettings.DBList)
            {
                DB.LastUsed = false;
            }
            
            DatabaseSetting DBSet = FindDBSetting(this.ProfileComboBox.Text);
            if (DBSet == null)
            {
                DatabaseSetting NewDBSet = new DatabaseSetting();
                NewDBSet.SettingName = this.ProfileComboBox.Text;
                NewDBSet.MSSQLName = this.MSSQLServerNameComboBox.Text;
                NewDBSet.MSSQLLogin = this.MSSQLLogin.Text;
                NewDBSet.MSSQLPass = this.MSSQLPass.Text;
                NewDBSet.MSSQLWInAuth = this.WinAuthCheckBox.Checked;
                NewDBSet.Query = this.QueryTextBox.Text;
                NewDBSet.LastUsed = true;
                NewDBSet.Update = Convert.ToInt32(this.QueryUpdateTime.Text, 10);
                AllDatabaseSettings.SaveDatabaseSetting(NewDBSet);
                this.ProfileComboBox.Items.Add(NewDBSet.SettingName);
            }
            else
            {
                DBSet.SettingName = this.ProfileComboBox.Text;
                DBSet.MSSQLName = this.MSSQLServerNameComboBox.Text;
                DBSet.MSSQLLogin = this.MSSQLLogin.Text;
                DBSet.MSSQLPass = this.MSSQLPass.Text;
                DBSet.MSSQLWInAuth = this.WinAuthCheckBox.Checked;
                DBSet.Query = this.QueryTextBox.Text;
                DBSet.Update = Convert.ToInt32(this.QueryUpdateTime.Text,10);
                DBSet.LastUsed = true;
            }
            SaveIntoReg();
        }

        private void ProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseSetting DBSet = FindDBSetting(this.ProfileComboBox.Text);
            if (DBSet != null)
            {
                this.ProfileComboBox.Text = DBSet.SettingName;
                this.MSSQLServerNameComboBox.Text = DBSet.MSSQLName;
                this.WinAuthCheckBox.Checked = DBSet.MSSQLWInAuth;
                this.MSSQLLogin.Text = DBSet.MSSQLLogin;
                this.MSSQLPass.Text = DBSet.MSSQLPass;
                this.QueryTextBox.Text = DBSet.Query;
                this.QueryUpdateTime.Text = DBSet.Update.ToString();
                this.QueryTimerTextBox.Text = DBSet.Update.ToString();
                DBSet.LastUsed = true;
            }
        }

        private void QueryTimerTextBox_TextChanged(object sender, EventArgs e)
        {
            this.QueryUpdateTime.Text = this.QueryTimerTextBox.Text;
        }

        private void QueryUpdate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.QueryTimerTextBox.Text = this.QueryUpdateTime.Text;
        }

        private void MSSQLViewerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.SQLConn.State == ConnectionState.Open) this.SQLConn.Close();
            ProfileSaveButton_Click(this.ProfileComboBox, null);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.QueryTimer.Interval = Convert.ToInt32(this.QueryTimerTextBox.Text, 10)*1000;
            this.QueryTimer.Enabled = true;
            UpdateMSSQLQuery();
        }

        private bool UpdateMSSQLQuery()
        {
            SqlConnectionStringBuilder SQLConStr = new SqlConnectionStringBuilder();
            if (this.MSSQLServerNameComboBox.Text == ""){ SQLConStr.DataSource = "(local)"; }
            else { SQLConStr.DataSource = this.MSSQLServerNameComboBox.Text; }

            if (this.WinAuthCheckBox.Checked)
            {
                SQLConStr.IntegratedSecurity = true;
                SQLConStr["Trusted_Connection"] = true;
            }
            else
            {
                SQLConStr.UserID = this.MSSQLLogin.Text;
                SQLConStr.Password = this.MSSQLPass.Text;
            }

            SQLConStr["Connect Timeout"] = 30;
            string connectionString = SQLConStr.ConnectionString;
            string sql = this.QueryTextBox.Text;

            using (this.SQLConn = new SqlConnection(connectionString))
            using (this.SQLCmd = new SqlCommand(sql, this.SQLConn))
            using (this.SQLAdapter = new SqlDataAdapter(this.SQLCmd))
            {
                try
                {
                    if (this.SQLConn.State != ConnectionState.Open) this.SQLConn.Open();
                    this.SQLTable.Clear();
                    this.SQLTable.Columns.Clear();
                    this.SQLAdapter.Fill(this.SQLTable);
                    this.SQLDataGridView.DataSource = this.SQLTable;
                    return true;
                }
                catch (SqlException e)
                {
                    DialogResult result = MessageBox.Show(e.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.QueryTimer.Enabled = false;
                    return false;
                }
                catch (InvalidOperationException e)
                {
                    DialogResult result = MessageBox.Show(e.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.QueryTimer.Enabled = false;
                    return false;
                }

            }
        }

        private void QueryTimer_Tick(object sender, EventArgs e)
        {
            UpdateMSSQLQuery();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            this.QueryTimer.Enabled = false;
            this.SQLConn.Close();
        }

        private void ProfileDeleteButton_Click(object sender, EventArgs e)
        {
            DatabaseSetting DBSet = FindDBSetting(this.ProfileComboBox.Text);
            if (DBSet == null)
            {
                this.ProfileComboBox.Text = "";
                this.MSSQLServerNameComboBox.Text = "";
                this.MSSQLLogin.Text = "";
                this.MSSQLPass.Text = "";
                this.WinAuthCheckBox.Checked = true;
                this.QueryTextBox.Text = "";
                this.QueryUpdateTime.Text = "30";
            }
            else
            {
                AllDatabaseSettings.DeleteDatabaseSetting(DBSet);
                SaveIntoReg();
            }
        }
    }
}
