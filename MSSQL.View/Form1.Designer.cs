namespace MSSQL.View
{
    partial class MSSQLViewerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MSSQLServerNameLabel = new System.Windows.Forms.Label();
            this.MSSQLSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.WinAuthCheckBox = new System.Windows.Forms.CheckBox();
            this.MSSQLLogin = new System.Windows.Forms.TextBox();
            this.MSSQLPass = new System.Windows.Forms.TextBox();
            this.MSSQLServerNameComboBox = new System.Windows.Forms.ComboBox();
            this.MSSQLPassLabel = new System.Windows.Forms.Label();
            this.MSSQLLoginLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.QueryTimerTextBox = new System.Windows.Forms.MaskedTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MSSQL.View.DataSet1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.ProfileSaveButton = new System.Windows.Forms.Button();
            this.ProfileLoadButton = new System.Windows.Forms.Button();
            this.ProfileDeleteButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelDelimiter = new System.Windows.Forms.Label();
            this.QueryTextBox = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MSSQLSettingsGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSSQLServerNameLabel
            // 
            this.MSSQLServerNameLabel.AutoSize = true;
            this.MSSQLServerNameLabel.Location = new System.Drawing.Point(-3, 7);
            this.MSSQLServerNameLabel.Name = "MSSQLServerNameLabel";
            this.MSSQLServerNameLabel.Size = new System.Drawing.Size(112, 13);
            this.MSSQLServerNameLabel.TabIndex = 0;
            this.MSSQLServerNameLabel.Text = "MS SQL Server Name";
            // 
            // MSSQLSettingsGroupBox
            // 
            this.MSSQLSettingsGroupBox.AutoSize = true;
            this.MSSQLSettingsGroupBox.Controls.Add(this.panel4);
            this.MSSQLSettingsGroupBox.Controls.Add(this.panel3);
            this.MSSQLSettingsGroupBox.Controls.Add(this.panel2);
            this.MSSQLSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MSSQLSettingsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.MSSQLSettingsGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.MSSQLSettingsGroupBox.Name = "MSSQLSettingsGroupBox";
            this.MSSQLSettingsGroupBox.Size = new System.Drawing.Size(770, 529);
            this.MSSQLSettingsGroupBox.TabIndex = 1;
            this.MSSQLSettingsGroupBox.TabStop = false;
            this.MSSQLSettingsGroupBox.Text = "MS SQL Server settings";
            // 
            // WinAuthCheckBox
            // 
            this.WinAuthCheckBox.AutoSize = true;
            this.WinAuthCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WinAuthCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WinAuthCheckBox.Location = new System.Drawing.Point(33, 39);
            this.WinAuthCheckBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.WinAuthCheckBox.Name = "WinAuthCheckBox";
            this.WinAuthCheckBox.Size = new System.Drawing.Size(95, 17);
            this.WinAuthCheckBox.TabIndex = 3;
            this.WinAuthCheckBox.Text = "Windows Auth";
            this.WinAuthCheckBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.WinAuthCheckBox.UseVisualStyleBackColor = true;
            this.WinAuthCheckBox.CheckedChanged += new System.EventHandler(this.NTLMCheckBox_CheckedChanged);
            // 
            // MSSQLLogin
            // 
            this.MSSQLLogin.Location = new System.Drawing.Point(253, 37);
            this.MSSQLLogin.Name = "MSSQLLogin";
            this.MSSQLLogin.Size = new System.Drawing.Size(143, 20);
            this.MSSQLLogin.TabIndex = 2;
            // 
            // MSSQLPass
            // 
            this.MSSQLPass.Location = new System.Drawing.Point(516, 37);
            this.MSSQLPass.Name = "MSSQLPass";
            this.MSSQLPass.Size = new System.Drawing.Size(143, 20);
            this.MSSQLPass.TabIndex = 2;
            // 
            // MSSQLServerNameComboBox
            // 
            this.MSSQLServerNameComboBox.FormattingEnabled = true;
            this.MSSQLServerNameComboBox.Location = new System.Drawing.Point(115, 3);
            this.MSSQLServerNameComboBox.Name = "MSSQLServerNameComboBox";
            this.MSSQLServerNameComboBox.Size = new System.Drawing.Size(320, 21);
            this.MSSQLServerNameComboBox.TabIndex = 1;
            // 
            // MSSQLPassLabel
            // 
            this.MSSQLPassLabel.AutoSize = true;
            this.MSSQLPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MSSQLPassLabel.Location = new System.Drawing.Point(410, 40);
            this.MSSQLPassLabel.Name = "MSSQLPassLabel";
            this.MSSQLPassLabel.Size = new System.Drawing.Size(96, 13);
            this.MSSQLPassLabel.TabIndex = 0;
            this.MSSQLPassLabel.Text = "MS SQL Password";
            // 
            // MSSQLLoginLabel
            // 
            this.MSSQLLoginLabel.AutoSize = true;
            this.MSSQLLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MSSQLLoginLabel.Location = new System.Drawing.Point(171, 40);
            this.MSSQLLoginLabel.Name = "MSSQLLoginLabel";
            this.MSSQLLoginLabel.Size = new System.Drawing.Size(76, 13);
            this.MSSQLLoginLabel.TabIndex = 0;
            this.MSSQLLoginLabel.Text = "MS SQL Login";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 561);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SQL View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update (sec):";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(770, 503);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MSSQLSettingsGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Setting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // QueryTimerTextBox
            // 
            this.QueryTimerTextBox.Location = new System.Drawing.Point(80, 2);
            this.QueryTimerTextBox.Mask = "00000";
            this.QueryTimerTextBox.Name = "QueryTimerTextBox";
            this.QueryTimerTextBox.PromptChar = ' ';
            this.QueryTimerTextBox.Size = new System.Drawing.Size(38, 20);
            this.QueryTimerTextBox.TabIndex = 3;
            this.QueryTimerTextBox.Text = "30";
            this.QueryTimerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.QueryTimerTextBox.ValidatingType = typeof(int);
            this.QueryTimerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QueryTimerTextBox_KeyPress);
            this.QueryTimerTextBox.Leave += new System.EventHandler(this.QueryTimerTextBox_Leave);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(770, 529);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.QueryTimerTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(647, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 25);
            this.panel1.TabIndex = 4;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.dataSet1;
            this.bindingSource1.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Location = new System.Drawing.Point(73, 10);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(36, 13);
            this.ProfileLabel.TabIndex = 0;
            this.ProfileLabel.Text = "Profile";
            // 
            // ProfileSaveButton
            // 
            this.ProfileSaveButton.Location = new System.Drawing.Point(568, 7);
            this.ProfileSaveButton.Name = "ProfileSaveButton";
            this.ProfileSaveButton.Size = new System.Drawing.Size(75, 23);
            this.ProfileSaveButton.TabIndex = 2;
            this.ProfileSaveButton.Text = "Save";
            this.ProfileSaveButton.UseVisualStyleBackColor = true;
            this.ProfileSaveButton.Click += new System.EventHandler(this.ProfileSaveButton_Click);
            // 
            // ProfileLoadButton
            // 
            this.ProfileLoadButton.Location = new System.Drawing.Point(477, 7);
            this.ProfileLoadButton.Name = "ProfileLoadButton";
            this.ProfileLoadButton.Size = new System.Drawing.Size(75, 23);
            this.ProfileLoadButton.TabIndex = 2;
            this.ProfileLoadButton.Text = "Load";
            this.ProfileLoadButton.UseVisualStyleBackColor = true;
            // 
            // ProfileDeleteButton
            // 
            this.ProfileDeleteButton.Location = new System.Drawing.Point(659, 7);
            this.ProfileDeleteButton.Name = "ProfileDeleteButton";
            this.ProfileDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ProfileDeleteButton.TabIndex = 2;
            this.ProfileDeleteButton.Text = "Delete";
            this.ProfileDeleteButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProfileLabel);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.ProfileSaveButton);
            this.panel2.Controls.Add(this.ProfileLoadButton);
            this.panel2.Controls.Add(this.ProfileDeleteButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.MaximumSize = new System.Drawing.Size(0, 36);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 36);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.MSSQLLogin);
            this.panel3.Controls.Add(this.MSSQLPass);
            this.panel3.Controls.Add(this.WinAuthCheckBox);
            this.panel3.Controls.Add(this.MSSQLServerNameLabel);
            this.panel3.Controls.Add(this.MSSQLPassLabel);
            this.panel3.Controls.Add(this.LabelDelimiter);
            this.panel3.Controls.Add(this.MSSQLLoginLabel);
            this.panel3.Controls.Add(this.MSSQLServerNameComboBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 52);
            this.panel3.MaximumSize = new System.Drawing.Size(0, 65);
            this.panel3.MinimumSize = new System.Drawing.Size(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 65);
            this.panel3.TabIndex = 7;
            // 
            // LabelDelimiter
            // 
            this.LabelDelimiter.AutoSize = true;
            this.LabelDelimiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDelimiter.Location = new System.Drawing.Point(137, 39);
            this.LabelDelimiter.Name = "LabelDelimiter";
            this.LabelDelimiter.Size = new System.Drawing.Size(28, 13);
            this.LabelDelimiter.TabIndex = 0;
            this.LabelDelimiter.Text = ">>>:";
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryTextBox.Location = new System.Drawing.Point(0, 0);
            this.QueryTextBox.MinimumSize = new System.Drawing.Size(0, 250);
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(764, 403);
            this.QueryTextBox.TabIndex = 0;
            this.QueryTextBox.Text = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.QueryTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 123);
            this.panel4.MinimumSize = new System.Drawing.Size(0, 400);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(764, 403);
            this.panel4.TabIndex = 8;
            // 
            // MSSQLViewerForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "MSSQLViewerForm";
            this.Text = "MS SQL Viewer";
            this.Load += new System.EventHandler(this.MSSQLViewerForm_Load);
            this.MSSQLSettingsGroupBox.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MSSQLServerNameLabel;
        private System.Windows.Forms.GroupBox MSSQLSettingsGroupBox;
        private System.Windows.Forms.ComboBox MSSQLServerNameComboBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label MSSQLLoginLabel;
        private System.Windows.Forms.CheckBox WinAuthCheckBox;
        private System.Windows.Forms.TextBox MSSQLLogin;
        private System.Windows.Forms.TextBox MSSQLPass;
        private System.Windows.Forms.Label MSSQLPassLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MaskedTextBox QueryTimerTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.Button ProfileDeleteButton;
        private System.Windows.Forms.Button ProfileLoadButton;
        private System.Windows.Forms.Button ProfileSaveButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelDelimiter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox QueryTextBox;
    }
}

