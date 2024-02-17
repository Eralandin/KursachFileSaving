namespace KursachFileSaving.View.Forms.WorkTypesForms
{
    partial class WTControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WTControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVWTs = new System.Windows.Forms.DataGridView();
            this.BotWTsPanel = new System.Windows.Forms.Panel();
            this.WTSearchLabel = new System.Windows.Forms.Label();
            this.WTBotLabel = new System.Windows.Forms.Label();
            this.WTSearchTextBox = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.WTsAddButton = new KursachFileSaving.View.Parts.CustomerButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVWTs)).BeginInit();
            this.BotWTsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WTsAddButton)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVWTs
            // 
            this.DGVWTs.AllowUserToAddRows = false;
            this.DGVWTs.AllowUserToDeleteRows = false;
            this.DGVWTs.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVWTs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.DGVWTs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVWTs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Code,
            this.WorkName,
            this.Comm,
            this.Edit,
            this.Delete});
            this.DGVWTs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVWTs.Location = new System.Drawing.Point(0, 0);
            this.DGVWTs.Name = "DGVWTs";
            this.DGVWTs.ReadOnly = true;
            this.DGVWTs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVWTs.Size = new System.Drawing.Size(1050, 531);
            this.DGVWTs.TabIndex = 11;
            this.DGVWTs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVWTs_CellContentClick);
            // 
            // BotWTsPanel
            // 
            this.BotWTsPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.BotWTsPanel.Controls.Add(this.WTsAddButton);
            this.BotWTsPanel.Controls.Add(this.WTSearchLabel);
            this.BotWTsPanel.Controls.Add(this.WTBotLabel);
            this.BotWTsPanel.Controls.Add(this.WTSearchTextBox);
            this.BotWTsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotWTsPanel.Location = new System.Drawing.Point(0, 531);
            this.BotWTsPanel.Name = "BotWTsPanel";
            this.BotWTsPanel.Size = new System.Drawing.Size(1050, 35);
            this.BotWTsPanel.TabIndex = 10;
            // 
            // WTSearchLabel
            // 
            this.WTSearchLabel.AutoSize = true;
            this.WTSearchLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WTSearchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WTSearchLabel.Location = new System.Drawing.Point(576, 4);
            this.WTSearchLabel.Name = "WTSearchLabel";
            this.WTSearchLabel.Size = new System.Drawing.Size(67, 23);
            this.WTSearchLabel.TabIndex = 20;
            this.WTSearchLabel.Text = "Поиск:";
            // 
            // WTBotLabel
            // 
            this.WTBotLabel.AutoSize = true;
            this.WTBotLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WTBotLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WTBotLabel.Location = new System.Drawing.Point(10, 6);
            this.WTBotLabel.Name = "WTBotLabel";
            this.WTBotLabel.Size = new System.Drawing.Size(185, 23);
            this.WTBotLabel.TabIndex = 3;
            this.WTBotLabel.Text = "Список типов работ";
            // 
            // WTSearchTextBox
            // 
            this.WTSearchTextBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WTSearchTextBox.Location = new System.Drawing.Point(646, 3);
            this.WTSearchTextBox.Name = "WTSearchTextBox";
            this.WTSearchTextBox.Size = new System.Drawing.Size(238, 27);
            this.WTSearchTextBox.TabIndex = 19;
            this.WTSearchTextBox.TextChanged += new System.EventHandler(this.WTSearchTextBox_TextChanged);
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Number.DefaultCellStyle = dataGridViewCellStyle20;
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 70;
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Code.DefaultCellStyle = dataGridViewCellStyle21;
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 55;
            // 
            // WorkName
            // 
            this.WorkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.WorkName.DefaultCellStyle = dataGridViewCellStyle22;
            this.WorkName.HeaderText = "Наименование";
            this.WorkName.Name = "WorkName";
            this.WorkName.ReadOnly = true;
            this.WorkName.Width = 119;
            // 
            // Comm
            // 
            this.Comm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Comm.DefaultCellStyle = dataGridViewCellStyle23;
            this.Comm.HeaderText = "Комментарий";
            this.Comm.Name = "Comm";
            this.Comm.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle26.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle26.NullValue")));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle27.NullValue")));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 5;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle24.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle24.NullValue")));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle24;
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle25.NullValue")));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle25;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 5;
            // 
            // WTsAddButton
            // 
            this.WTsAddButton.Image = global::KursachFileSaving.Properties.Resources.PlusNormal;
            this.WTsAddButton.ImageHover = global::KursachFileSaving.Properties.Resources.PlusHover;
            this.WTsAddButton.ImageNormal = global::KursachFileSaving.Properties.Resources.PlusNormal;
            this.WTsAddButton.Location = new System.Drawing.Point(1019, 4);
            this.WTsAddButton.Name = "WTsAddButton";
            this.WTsAddButton.Size = new System.Drawing.Size(28, 28);
            this.WTsAddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WTsAddButton.TabIndex = 10;
            this.WTsAddButton.TabStop = false;
            this.WTsAddButton.Click += new System.EventHandler(this.WTsAddButton_Click);
            // 
            // WTControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 566);
            this.Controls.Add(this.DGVWTs);
            this.Controls.Add(this.BotWTsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WTControl";
            this.Text = "WTControl";
            ((System.ComponentModel.ISupportInitialize)(this.DGVWTs)).EndInit();
            this.BotWTsPanel.ResumeLayout(false);
            this.BotWTsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WTsAddButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGVWTs;
        private System.Windows.Forms.Panel BotWTsPanel;
        private Parts.CustomerButton WTsAddButton;
        private System.Windows.Forms.Label WTSearchLabel;
        private System.Windows.Forms.Label WTBotLabel;
        public System.Windows.Forms.TextBox WTSearchTextBox;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comm;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}