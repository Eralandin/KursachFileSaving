namespace KursachFileSaving.View.Forms.JournalControlForms
{
    partial class JournalControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.JournalAddButton = new KursachFileSaving.View.Parts.CustomerButton();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.JobsSearchLabel = new System.Windows.Forms.Label();
            this.JobsBotLabel = new System.Windows.Forms.Label();
            this.JournalSearchTextBox = new System.Windows.Forms.TextBox();
            this.BotJobsPanel = new System.Windows.Forms.Panel();
            this.DGVJournal = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVBlockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVWorkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVAppCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVAppComm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.JournalAddButton)).BeginInit();
            this.BotJobsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVJournal)).BeginInit();
            this.SuspendLayout();
            // 
            // JournalAddButton
            // 
            this.JournalAddButton.Image = global::KursachFileSaving.Properties.Resources.PlusNormal;
            this.JournalAddButton.ImageHover = global::KursachFileSaving.Properties.Resources.PlusHover;
            this.JournalAddButton.ImageNormal = global::KursachFileSaving.Properties.Resources.PlusNormal;
            this.JournalAddButton.Location = new System.Drawing.Point(1019, 4);
            this.JournalAddButton.Name = "JournalAddButton";
            this.JournalAddButton.Size = new System.Drawing.Size(28, 28);
            this.JournalAddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.JournalAddButton.TabIndex = 10;
            this.JournalAddButton.TabStop = false;
            this.JournalAddButton.Click += new System.EventHandler(this.JournalAddButton_Click);
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // JobsSearchLabel
            // 
            this.JobsSearchLabel.AutoSize = true;
            this.JobsSearchLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JobsSearchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.JobsSearchLabel.Location = new System.Drawing.Point(576, 4);
            this.JobsSearchLabel.Name = "JobsSearchLabel";
            this.JobsSearchLabel.Size = new System.Drawing.Size(67, 23);
            this.JobsSearchLabel.TabIndex = 20;
            this.JobsSearchLabel.Text = "Поиск:";
            // 
            // JobsBotLabel
            // 
            this.JobsBotLabel.AutoSize = true;
            this.JobsBotLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JobsBotLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.JobsBotLabel.Location = new System.Drawing.Point(10, 6);
            this.JobsBotLabel.Name = "JobsBotLabel";
            this.JobsBotLabel.Size = new System.Drawing.Size(266, 23);
            this.JobsBotLabel.TabIndex = 3;
            this.JobsBotLabel.Text = "Журнал завершённых заявок";
            // 
            // JournalSearchTextBox
            // 
            this.JournalSearchTextBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JournalSearchTextBox.Location = new System.Drawing.Point(646, 3);
            this.JournalSearchTextBox.Name = "JournalSearchTextBox";
            this.JournalSearchTextBox.Size = new System.Drawing.Size(238, 27);
            this.JournalSearchTextBox.TabIndex = 19;
            this.JournalSearchTextBox.TextChanged += new System.EventHandler(this.JournalSearchTextBox_TextChanged);
            // 
            // BotJobsPanel
            // 
            this.BotJobsPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.BotJobsPanel.Controls.Add(this.JournalAddButton);
            this.BotJobsPanel.Controls.Add(this.JobsSearchLabel);
            this.BotJobsPanel.Controls.Add(this.JobsBotLabel);
            this.BotJobsPanel.Controls.Add(this.JournalSearchTextBox);
            this.BotJobsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotJobsPanel.Location = new System.Drawing.Point(0, 531);
            this.BotJobsPanel.Name = "BotJobsPanel";
            this.BotJobsPanel.Size = new System.Drawing.Size(1050, 35);
            this.BotJobsPanel.TabIndex = 12;
            // 
            // DGVJournal
            // 
            this.DGVJournal.AllowUserToAddRows = false;
            this.DGVJournal.AllowUserToDeleteRows = false;
            this.DGVJournal.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVJournal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVJournal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.RecordCode,
            this.DGVBlockCode,
            this.DGVWorkType,
            this.DGVAppCode,
            this.DGVAppComm,
            this.Date,
            this.DateEnd,
            this.Delete});
            this.DGVJournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVJournal.Location = new System.Drawing.Point(0, 0);
            this.DGVJournal.Name = "DGVJournal";
            this.DGVJournal.ReadOnly = true;
            this.DGVJournal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVJournal.Size = new System.Drawing.Size(1050, 566);
            this.DGVJournal.TabIndex = 13;
            this.DGVJournal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVJournal_CellContentClick);
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Number.DefaultCellStyle = dataGridViewCellStyle4;
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Number.Width = 51;
            // 
            // RecordCode
            // 
            this.RecordCode.HeaderText = "Код записи";
            this.RecordCode.Name = "RecordCode";
            this.RecordCode.ReadOnly = true;
            this.RecordCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DGVBlockCode
            // 
            this.DGVBlockCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DGVBlockCode.HeaderText = "Код блока";
            this.DGVBlockCode.Name = "DGVBlockCode";
            this.DGVBlockCode.ReadOnly = true;
            this.DGVBlockCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DGVBlockCode.Width = 74;
            // 
            // DGVWorkType
            // 
            this.DGVWorkType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DGVWorkType.HeaderText = "Код типа работы";
            this.DGVWorkType.Name = "DGVWorkType";
            this.DGVWorkType.ReadOnly = true;
            this.DGVWorkType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DGVWorkType.Width = 102;
            // 
            // DGVAppCode
            // 
            this.DGVAppCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.DGVAppCode.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGVAppCode.HeaderText = "Код заявки";
            this.DGVAppCode.Name = "DGVAppCode";
            this.DGVAppCode.ReadOnly = true;
            this.DGVAppCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DGVAppCode.Width = 72;
            // 
            // DGVAppComm
            // 
            this.DGVAppComm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.DGVAppComm.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVAppComm.HeaderText = "Комментарий";
            this.DGVAppComm.Name = "DGVAppComm";
            this.DGVAppComm.ReadOnly = true;
            this.DGVAppComm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date.HeaderText = "Дата начала";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date.Width = 79;
            // 
            // DateEnd
            // 
            this.DateEnd.HeaderText = "Дата окончания";
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.ReadOnly = true;
            this.DateEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle7;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 5;
            // 
            // JournalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 566);
            this.Controls.Add(this.BotJobsPanel);
            this.Controls.Add(this.DGVJournal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JournalControl";
            this.Text = "JournalControl";
            ((System.ComponentModel.ISupportInitialize)(this.JournalAddButton)).EndInit();
            this.BotJobsPanel.ResumeLayout(false);
            this.BotJobsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVJournal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Parts.CustomerButton JournalAddButton;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label JobsSearchLabel;
        private System.Windows.Forms.Label JobsBotLabel;
        public System.Windows.Forms.TextBox JournalSearchTextBox;
        private System.Windows.Forms.Panel BotJobsPanel;
        public System.Windows.Forms.DataGridView DGVJournal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVBlockCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVWorkType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVAppCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVAppComm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnd;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}