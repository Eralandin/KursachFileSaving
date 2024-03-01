namespace KursachFileSaving.View.Forms.AppsControlForms
{
    partial class AppsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppsControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVApps = new System.Windows.Forms.DataGridView();
            this.BotJobsPanel = new System.Windows.Forms.Panel();
            this.AppsAddButton = new KursachFileSaving.View.Parts.CustomerButton();
            this.JobsSearchLabel = new System.Windows.Forms.Label();
            this.JobsBotLabel = new System.Windows.Forms.Label();
            this.AppsSearchTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVAppCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVAppComm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVBlockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVWorkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVApps)).BeginInit();
            this.BotJobsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppsAddButton)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVApps
            // 
            this.DGVApps.AllowUserToAddRows = false;
            this.DGVApps.AllowUserToDeleteRows = false;
            this.DGVApps.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVApps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.DGVAppCode,
            this.DGVAppComm,
            this.Day,
            this.Month,
            this.Year,
            this.DGVBlockCode,
            this.DGVWorkType,
            this.Edit,
            this.Delete});
            this.DGVApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVApps.Location = new System.Drawing.Point(0, 0);
            this.DGVApps.Name = "DGVApps";
            this.DGVApps.ReadOnly = true;
            this.DGVApps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVApps.Size = new System.Drawing.Size(1050, 531);
            this.DGVApps.TabIndex = 11;
            this.DGVApps.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVApps_CellContentClick);
            // 
            // BotJobsPanel
            // 
            this.BotJobsPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.BotJobsPanel.Controls.Add(this.AppsAddButton);
            this.BotJobsPanel.Controls.Add(this.JobsSearchLabel);
            this.BotJobsPanel.Controls.Add(this.JobsBotLabel);
            this.BotJobsPanel.Controls.Add(this.AppsSearchTextBox);
            this.BotJobsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotJobsPanel.Location = new System.Drawing.Point(0, 531);
            this.BotJobsPanel.Name = "BotJobsPanel";
            this.BotJobsPanel.Size = new System.Drawing.Size(1050, 35);
            this.BotJobsPanel.TabIndex = 10;
            // 
            // AppsAddButton
            // 
            this.AppsAddButton.Image = global::KursachFileSaving.Properties.Resources.PlusNormal;
            this.AppsAddButton.ImageHover = global::KursachFileSaving.Properties.Resources.PlusHover;
            this.AppsAddButton.ImageNormal = global::KursachFileSaving.Properties.Resources.PlusNormal;
            this.AppsAddButton.Location = new System.Drawing.Point(1019, 4);
            this.AppsAddButton.Name = "AppsAddButton";
            this.AppsAddButton.Size = new System.Drawing.Size(28, 28);
            this.AppsAddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppsAddButton.TabIndex = 10;
            this.AppsAddButton.TabStop = false;
            this.AppsAddButton.Click += new System.EventHandler(this.AppsAddButton_Click);
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
            this.JobsBotLabel.Size = new System.Drawing.Size(137, 23);
            this.JobsBotLabel.TabIndex = 3;
            this.JobsBotLabel.Text = "Список заявок";
            // 
            // AppsSearchTextBox
            // 
            this.AppsSearchTextBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppsSearchTextBox.Location = new System.Drawing.Point(646, 3);
            this.AppsSearchTextBox.Name = "AppsSearchTextBox";
            this.AppsSearchTextBox.Size = new System.Drawing.Size(238, 27);
            this.AppsSearchTextBox.TabIndex = 19;
            this.AppsSearchTextBox.TextChanged += new System.EventHandler(this.AppsSearchTextBox_TextChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Number.DefaultCellStyle = dataGridViewCellStyle2;
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Number.Width = 51;
            // 
            // DGVAppCode
            // 
            this.DGVAppCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.DGVAppCode.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVAppCode.HeaderText = "Код заявки";
            this.DGVAppCode.Name = "DGVAppCode";
            this.DGVAppCode.ReadOnly = true;
            this.DGVAppCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DGVAppCode.Width = 80;
            // 
            // DGVAppComm
            // 
            this.DGVAppComm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.DGVAppComm.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVAppComm.HeaderText = "Комментарий";
            this.DGVAppComm.Name = "DGVAppComm";
            this.DGVAppComm.ReadOnly = true;
            this.DGVAppComm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Day
            // 
            this.Day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Day.HeaderText = "День";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            this.Day.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Day.Width = 43;
            // 
            // Month
            // 
            this.Month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Month.HeaderText = "Месяц";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            this.Month.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Month.Width = 51;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Year.HeaderText = "Год";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Year.Width = 33;
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
            this.DGVWorkType.HeaderText = "Тип работы";
            this.DGVWorkType.Name = "DGVWorkType";
            this.DGVWorkType.ReadOnly = true;
            this.DGVWorkType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DGVWorkType.Width = 78;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle5;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle6;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 5;
            // 
            // AppsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 566);
            this.Controls.Add(this.DGVApps);
            this.Controls.Add(this.BotJobsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppsControl";
            this.Text = "AppsControl";
            ((System.ComponentModel.ISupportInitialize)(this.DGVApps)).EndInit();
            this.BotJobsPanel.ResumeLayout(false);
            this.BotJobsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppsAddButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGVApps;
        private System.Windows.Forms.Panel BotJobsPanel;
        private Parts.CustomerButton AppsAddButton;
        private System.Windows.Forms.Label JobsSearchLabel;
        private System.Windows.Forms.Label JobsBotLabel;
        public System.Windows.Forms.TextBox AppsSearchTextBox;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVAppCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVAppComm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVBlockCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVWorkType;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}