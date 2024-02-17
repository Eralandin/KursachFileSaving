namespace KursachFileSaving.View.Forms.JobsControlForms
{
    partial class JobsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobsControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVJobs = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.BotWTsPanel = new System.Windows.Forms.Panel();
            this.JobsAddButton = new KursachFileSaving.View.Parts.CustomerButton();
            this.JobsSearchLabel = new System.Windows.Forms.Label();
            this.JobsBotLabel = new System.Windows.Forms.Label();
            this.JobsSearchTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVJobs)).BeginInit();
            this.BotWTsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobsAddButton)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVJobs
            // 
            this.DGVJobs.AllowUserToAddRows = false;
            this.DGVJobs.AllowUserToDeleteRows = false;
            this.DGVJobs.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Code,
            this.WorkName,
            this.Edit,
            this.Delete});
            this.DGVJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVJobs.Location = new System.Drawing.Point(0, 0);
            this.DGVJobs.Name = "DGVJobs";
            this.DGVJobs.ReadOnly = true;
            this.DGVJobs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVJobs.Size = new System.Drawing.Size(1050, 531);
            this.DGVJobs.TabIndex = 9;
            this.DGVJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVJobs_CellContentClick_1);
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Number.DefaultCellStyle = dataGridViewCellStyle2;
            this.Number.HeaderText = "Num.";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 62;
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Code.DefaultCellStyle = dataGridViewCellStyle3;
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // WorkName
            // 
            this.WorkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.WorkName.DefaultCellStyle = dataGridViewCellStyle4;
            this.WorkName.HeaderText = "Name";
            this.WorkName.Name = "WorkName";
            this.WorkName.ReadOnly = true;
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
            // BotWTsPanel
            // 
            this.BotWTsPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.BotWTsPanel.Controls.Add(this.JobsAddButton);
            this.BotWTsPanel.Controls.Add(this.JobsSearchLabel);
            this.BotWTsPanel.Controls.Add(this.JobsBotLabel);
            this.BotWTsPanel.Controls.Add(this.JobsSearchTextBox);
            this.BotWTsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotWTsPanel.Location = new System.Drawing.Point(0, 531);
            this.BotWTsPanel.Name = "BotWTsPanel";
            this.BotWTsPanel.Size = new System.Drawing.Size(1050, 35);
            this.BotWTsPanel.TabIndex = 8;
            // 
            // JobsAddButton
            // 
            this.JobsAddButton.Image = global::KursachFileSaving.Properties.Resources.PlusNormal;
            this.JobsAddButton.ImageHover = global::KursachFileSaving.Properties.Resources.PlusHover;
            this.JobsAddButton.ImageNormal = global::KursachFileSaving.Properties.Resources.PlusNormal;
            this.JobsAddButton.Location = new System.Drawing.Point(1010, 4);
            this.JobsAddButton.Name = "JobsAddButton";
            this.JobsAddButton.Size = new System.Drawing.Size(28, 28);
            this.JobsAddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.JobsAddButton.TabIndex = 10;
            this.JobsAddButton.TabStop = false;
            this.JobsAddButton.Click += new System.EventHandler(this.JobsAddButton_Click);
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
            this.JobsBotLabel.Size = new System.Drawing.Size(184, 23);
            this.JobsBotLabel.TabIndex = 3;
            this.JobsBotLabel.Text = "Список должностей";
            // 
            // JobsSearchTextBox
            // 
            this.JobsSearchTextBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JobsSearchTextBox.Location = new System.Drawing.Point(646, 3);
            this.JobsSearchTextBox.Name = "JobsSearchTextBox";
            this.JobsSearchTextBox.Size = new System.Drawing.Size(238, 27);
            this.JobsSearchTextBox.TabIndex = 19;
            this.JobsSearchTextBox.TextChanged += new System.EventHandler(this.JobsSearchTextBox_TextChanged);
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
            // JobsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 566);
            this.Controls.Add(this.DGVJobs);
            this.Controls.Add(this.BotWTsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JobsControl";
            this.Text = "JobsControl";
            ((System.ComponentModel.ISupportInitialize)(this.DGVJobs)).EndInit();
            this.BotWTsPanel.ResumeLayout(false);
            this.BotWTsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobsAddButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BotWTsPanel;
        private System.Windows.Forms.Label JobsSearchLabel;
        private System.Windows.Forms.Label JobsBotLabel;
        public System.Windows.Forms.TextBox JobsSearchTextBox;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkName;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private KursachFileSaving.View.Parts.CustomerButton JobsAddButton;
        public System.Windows.Forms.DataGridView DGVJobs;
    }
}