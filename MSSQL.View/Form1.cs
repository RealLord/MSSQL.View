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
        public SqlCommandBuilder SQLCmd         = new SqlCommandBuilder();
        public SqlDataAdapter SQLAdapter = new SqlDataAdapter();
        public DataTable SQLTable = new DataTable();

        public interface IDatabaseSettings
        {
            //IEnumerable<DatabaseSettings> GetAllDatabaseSetting();
            void SaveDatabaseSetting(DatabaseSetting DBSet);
        }

        public class DatabaseSettings: IDatabaseSettings
        {
            public IList<DatabaseSetting> DBList = new List<DatabaseSetting>(); // создали список из настроек
            //public IEnumerable<DatabaseSettings> GetAllDatabaseSetting() => DBList; // Список всех настроек
            public void SaveDatabaseSetting(DatabaseSetting DBSet) // записываем одну настройку
            {
                this.DBList.Add(DBSet);
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
                    this.QueryUpdate.Text = DB.Update.ToString();
                    this.QueryUpdate.Text = DB.Update.ToString();
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
        }

        private void QueryTimerTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void QueryTimerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
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
                NewDBSet.Update = Convert.ToInt32(this.QueryUpdate.Text, 10);
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
                DBSet.Update = Convert.ToInt32(this.QueryUpdate.Text,10);
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
                this.QueryUpdate.Text = DBSet.Update.ToString();
                this.QueryTimerTextBox.Text = DBSet.Update.ToString();
                DBSet.LastUsed = true;
            }
        }

        private void QueryTimerTextBox_TextChanged(object sender, EventArgs e)
        {
            this.QueryUpdate.Text = this.QueryTimerTextBox.Text;
        }

        private void QueryUpdate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.QueryTimerTextBox.Text = this.QueryUpdate.Text;
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
            PrepareMSSQLConnection();
            UpdateMSSQLQuery();
        }

        private bool PrepareMSSQLConnection()
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
            SQLConStr.AsynchronousProcessing = true;

            this.SQLConn = new SqlConnection(SQLConStr.ConnectionString);
            this.SQLAdapter = new SqlDataAdapter(this.QueryTextBox.Text, this.SQLConn);
            this.SQLCmd = new SqlCommandBuilder(this.SQLAdapter);

            try { this.SQLConn.Open(); return true; }
            catch (SqlException e)
            {
                DialogResult result = MessageBox.Show(e.Source, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            /*
            string strCon = "Data Source=dbServer;Initial Catalog=testDB;Integrated Security=True";
            string strSQL = “select * from table1”;
            
            SqlDataAdapter dataAdapter = new SqlDataAdapter(strSQL, strCon);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            // Populate a new data table and bind it to the BindingSource.
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dbBindSource.DataSource = table;
            <o:p> 
            // Resize the DataGridView columns to fit the newly loaded content.
            dbGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            // you can make it grid readonly.
            dbGridView.ReadOnly = true; 
            // finally bind the data to the grid
            dbGridView.DataSource = dbBindSource;
            */


        }

        private void UpdateMSSQLQuery()
        {
            try {
                if (this.SQLConn.State != ConnectionState.Open ) this.SQLConn.Open();
                this.SQLAdapter.Fill(this.SQLTable);
                this.SQLBindingSource.DataSource = this.SQLTable;
                this.SQLDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                this.SQLDataGridView.DataSource = this.SQLBindingSource;
            }
            catch (SqlException e)
            {
                DialogResult result = MessageBox.Show(e.Source, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.SQLConn.Close();
            }
            catch (InvalidOperationException e)
            {
                DialogResult result = MessageBox.Show(e.Source, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.SQLConn.Close();
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

        private void MSSQLLoginLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
