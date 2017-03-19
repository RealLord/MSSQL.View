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

namespace MSSQL.View
{
    public partial class MSSQLViewerForm : Form
    {
        public string MSSQLName = "MS SQL Server Name";

        public MSSQLViewerForm()
        {
            InitializeComponent();
        }

        private void NTLMCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.WinAuthCheckBox.Checked == true)
            {
                this.MSSQLLoginLabel.Visible    = false;
                this.MSSQLLogin.Visible         = false;
                this.MSSQLPassLabel.Visible     = false;
                this.MSSQLPass.Visible          = false;
                //this.LabelDelimiter.Visible     = false;
            }
            else
            {
                this.MSSQLLoginLabel.Visible    = true;
                this.MSSQLLogin.Visible         = true;
                this.MSSQLPassLabel.Visible     = true;
                this.MSSQLPass.Visible          = true;
                //this.LabelDelimiter.Visible     = true;
            }
        }

        private void MSSQLViewerForm_Load(object sender, EventArgs e)
        {
            this.WinAuthCheckBox.Checked = true;
            NTLMCheckBox_CheckedChanged(this.WinAuthCheckBox, null);
        }

        private void QueryTimerTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void QueryTimerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.dataGridView1.Focus();
            }
        }

        private void ProfileSaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
