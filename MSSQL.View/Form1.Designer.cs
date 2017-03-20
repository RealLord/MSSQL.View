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
            this.panel4 = new System.Windows.Forms.Panel();
            this.QueryUpdateTime = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QueryTextBox = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MSSQLLogin = new System.Windows.Forms.TextBox();
            this.MSSQLPass = new System.Windows.Forms.TextBox();
            this.WinAuthCheckBox = new System.Windows.Forms.CheckBox();
            this.MSSQLPassLabel = new System.Windows.Forms.Label();
            this.LabelDelimiter = new System.Windows.Forms.Label();
            this.MSSQLLoginLabel = new System.Windows.Forms.Label();
            this.MSSQLServerNameComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.ProfileComboBox = new System.Windows.Forms.ComboBox();
            this.ProfileSaveButton = new System.Windows.Forms.Button();
            this.ProfileDeleteButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QueryTimerTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SQLDataGridView = new System.Windows.Forms.DataGridView();
            this.SQLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SQLDataSet = new MSSQL.View.DataSet1();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.QueryTimer = new System.Windows.Forms.Timer(this.components);
            this.MSSQLSettingsGroupBox.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQLDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SQLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SQLDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSSQLServerNameLabel
            // 
            this.MSSQLServerNameLabel.AutoSize = true;
            this.MSSQLServerNameLabel.Location = new System.Drawing.Point(0, 7);
            this.MSSQLServerNameLabel.Name = "MSSQLServerNameLabel";
            this.MSSQLServerNameLabel.Size = new System.Drawing.Size(115, 13);
            this.MSSQLServerNameLabel.TabIndex = 0;
            this.MSSQLServerNameLabel.Text = "MS SQL Server Name:";
            this.MSSQLServerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.QueryUpdateTime);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.QueryTextBox);
            this.panel4.Location = new System.Drawing.Point(3, 123);
            this.panel4.MinimumSize = new System.Drawing.Size(0, 400);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(764, 403);
            this.panel4.TabIndex = 8;
            // 
            // QueryUpdateTime
            // 
            this.QueryUpdateTime.Location = new System.Drawing.Point(115, 5);
            this.QueryUpdateTime.Mask = "00000";
            this.QueryUpdateTime.Name = "QueryUpdateTime";
            this.QueryUpdateTime.PromptChar = ' ';
            this.QueryUpdateTime.Size = new System.Drawing.Size(38, 20);
            this.QueryUpdateTime.TabIndex = 4;
            this.QueryUpdateTime.Text = "30";
            this.QueryUpdateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.QueryUpdateTime.ValidatingType = typeof(int);
            this.QueryUpdateTime.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.QueryUpdate_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Query update (sec):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Query text:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryTextBox.Location = new System.Drawing.Point(115, 30);
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(646, 370);
            this.QueryTextBox.TabIndex = 0;
            this.QueryTextBox.Text = "";
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
            // MSSQLLogin
            // 
            this.MSSQLLogin.Location = new System.Drawing.Point(255, 37);
            this.MSSQLLogin.Name = "MSSQLLogin";
            this.MSSQLLogin.Size = new System.Drawing.Size(143, 20);
            this.MSSQLLogin.TabIndex = 2;
            // 
            // MSSQLPass
            // 
            this.MSSQLPass.Location = new System.Drawing.Point(516, 37);
            this.MSSQLPass.Name = "MSSQLPass";
            this.MSSQLPass.PasswordChar = '*';
            this.MSSQLPass.ShortcutsEnabled = false;
            this.MSSQLPass.Size = new System.Drawing.Size(143, 20);
            this.MSSQLPass.TabIndex = 2;
            this.MSSQLPass.UseSystemPasswordChar = true;
            this.MSSQLPass.WordWrap = false;
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
            // 
            // MSSQLPassLabel
            // 
            this.MSSQLPassLabel.AutoSize = true;
            this.MSSQLPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MSSQLPassLabel.Location = new System.Drawing.Point(410, 40);
            this.MSSQLPassLabel.Name = "MSSQLPassLabel";
            this.MSSQLPassLabel.Size = new System.Drawing.Size(104, 13);
            this.MSSQLPassLabel.TabIndex = 0;
            this.MSSQLPassLabel.Text = "SQL/Win Password:";
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
            // MSSQLLoginLabel
            // 
            this.MSSQLLoginLabel.AutoSize = true;
            this.MSSQLLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MSSQLLoginLabel.Location = new System.Drawing.Point(171, 40);
            this.MSSQLLoginLabel.Name = "MSSQLLoginLabel";
            this.MSSQLLoginLabel.Size = new System.Drawing.Size(84, 13);
            this.MSSQLLoginLabel.TabIndex = 0;
            this.MSSQLLoginLabel.Text = "SQL/Win Login:";
            // 
            // MSSQLServerNameComboBox
            // 
            this.MSSQLServerNameComboBox.FormattingEnabled = true;
            this.MSSQLServerNameComboBox.Location = new System.Drawing.Point(115, 3);
            this.MSSQLServerNameComboBox.Name = "MSSQLServerNameComboBox";
            this.MSSQLServerNameComboBox.Size = new System.Drawing.Size(320, 21);
            this.MSSQLServerNameComboBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProfileLabel);
            this.panel2.Controls.Add(this.ProfileComboBox);
            this.panel2.Controls.Add(this.ProfileSaveButton);
            this.panel2.Controls.Add(this.ProfileDeleteButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.MaximumSize = new System.Drawing.Size(0, 36);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 36);
            this.panel2.TabIndex = 4;
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Location = new System.Drawing.Point(76, 10);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(39, 13);
            this.ProfileLabel.TabIndex = 0;
            this.ProfileLabel.Text = "Profile:";
            this.ProfileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProfileComboBox
            // 
            this.ProfileComboBox.FormattingEnabled = true;
            this.ProfileComboBox.Location = new System.Drawing.Point(115, 7);
            this.ProfileComboBox.Name = "ProfileComboBox";
            this.ProfileComboBox.Size = new System.Drawing.Size(320, 21);
            this.ProfileComboBox.TabIndex = 1;
            this.ProfileComboBox.SelectedIndexChanged += new System.EventHandler(this.ProfileComboBox_SelectedIndexChanged);
            // 
            // ProfileSaveButton
            // 
            this.ProfileSaveButton.Location = new System.Drawing.Point(471, 7);
            this.ProfileSaveButton.Name = "ProfileSaveButton";
            this.ProfileSaveButton.Size = new System.Drawing.Size(75, 23);
            this.ProfileSaveButton.TabIndex = 2;
            this.ProfileSaveButton.Text = "Save";
            this.ProfileSaveButton.UseVisualStyleBackColor = true;
            this.ProfileSaveButton.Click += new System.EventHandler(this.ProfileSaveButton_Click);
            // 
            // ProfileDeleteButton
            // 
            this.ProfileDeleteButton.Location = new System.Drawing.Point(562, 7);
            this.ProfileDeleteButton.Name = "ProfileDeleteButton";
            this.ProfileDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ProfileDeleteButton.TabIndex = 2;
            this.ProfileDeleteButton.Text = "Delete";
            this.ProfileDeleteButton.UseVisualStyleBackColor = true;
            this.ProfileDeleteButton.Click += new System.EventHandler(this.ProfileDeleteButton_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.StartButton);
            this.splitContainer1.Panel1.Controls.Add(this.StopButton);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SQLDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(770, 529);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 4;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(5, 1);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(96, 1);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 6;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.QueryTimerTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(647, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 25);
            this.panel1.TabIndex = 4;
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
            this.QueryTimerTextBox.TextChanged += new System.EventHandler(this.QueryTimerTextBox_TextChanged);
            this.QueryTimerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QueryTimerTextBox_KeyPress);
            this.QueryTimerTextBox.Leave += new System.EventHandler(this.QueryTimerTextBox_Leave);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update (sec):";
            // 
            // SQLDataGridView
            // 
            this.SQLDataGridView.AllowUserToAddRows = false;
            this.SQLDataGridView.AllowUserToDeleteRows = false;
            this.SQLDataGridView.AutoGenerateColumns = false;
            this.SQLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SQLDataGridView.DataSource = this.SQLBindingSource;
            this.SQLDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SQLDataGridView.Location = new System.Drawing.Point(0, 0);
            this.SQLDataGridView.Name = "SQLDataGridView";
            this.SQLDataGridView.ReadOnly = true;
            this.SQLDataGridView.Size = new System.Drawing.Size(770, 503);
            this.SQLDataGridView.TabIndex = 0;
            // 
            // SQLBindingSource
            // 
            this.SQLBindingSource.DataSource = this.SQLDataSet;
            this.SQLBindingSource.Position = 0;
            // 
            // SQLDataSet
            // 
            this.SQLDataSet.DataSetName = "SQLDataSet";
            this.SQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // QueryTimer
            // 
            this.QueryTimer.Tick += new System.EventHandler(this.QueryTimer_Tick);
            // 
            // MSSQLViewerForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MSSQLViewerForm";
            this.Text = "MS SQL Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MSSQLViewerForm_FormClosing);
            this.Load += new System.EventHandler(this.MSSQLViewerForm_Load);
            this.MSSQLSettingsGroupBox.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQLDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SQLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SQLDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MaskedTextBox QueryTimerTextBox;
        private System.Windows.Forms.Panel panel1;
        private DataSet1 SQLDataSet;
        private System.Windows.Forms.ComboBox ProfileComboBox;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.Button ProfileDeleteButton;
        private System.Windows.Forms.Button ProfileSaveButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelDelimiter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox QueryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer QueryTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox QueryUpdateTime;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.BindingSource SQLBindingSource;
        private System.Windows.Forms.DataGridView SQLDataGridView;
    }
}

