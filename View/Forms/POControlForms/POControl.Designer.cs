namespace KursachFileSaving.View.Forms.POControlForms
{
    partial class POControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVPOs = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.BotPOsPanel = new System.Windows.Forms.Panel();
            this.POsSearchLabel = new System.Windows.Forms.Label();
            this.POsBotLabel = new System.Windows.Forms.Label();
            this.POsSearchTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.POsAddButton = new KursachFileSaving.View.Parts.CustomerButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPOs)).BeginInit();
            this.BotPOsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.POsAddButton)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPOs
            // 
            this.DGVPOs.AllowUserToAddRows = false;
            this.DGVPOs.AllowUserToDeleteRows = false;
            this.DGVPOs.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPOs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.DGVPOs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPOs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Code,
            this.WorkName,
            this.BlockCode,
            this.Edit,
            this.Delete});
            this.DGVPOs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPOs.Location = new System.Drawing.Point(0, 0);
            this.DGVPOs.Name = "DGVPOs";
            this.DGVPOs.ReadOnly = true;
            this.DGVPOs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVPOs.Size = new System.Drawing.Size(1050, 531);
            this.DGVPOs.TabIndex = 11;
            this.DGVPOs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPOs_CellContentClick);
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Number.DefaultCellStyle = dataGridViewCellStyle34;
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 70;
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Code.DefaultCellStyle = dataGridViewCellStyle35;
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 55;
            // 
            // WorkName
            // 
            this.WorkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.WorkName.DefaultCellStyle = dataGridViewCellStyle36;
            this.WorkName.HeaderText = "Наименование";
            this.WorkName.Name = "WorkName";
            this.WorkName.ReadOnly = true;
            // 
            // BlockCode
            // 
            this.BlockCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BlockCode.HeaderText = "Код блока";
            this.BlockCode.Name = "BlockCode";
            this.BlockCode.ReadOnly = true;
            this.BlockCode.Width = 93;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle37.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle37.NullValue")));
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle37;
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
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle38.NullValue")));
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle38;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 5;
            // 
            // BotPOsPanel
            // 
            this.BotPOsPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.BotPOsPanel.Controls.Add(this.POsAddButton);
            this.BotPOsPanel.Controls.Add(this.POsSearchLabel);
            this.BotPOsPanel.Controls.Add(this.POsBotLabel);
            this.BotPOsPanel.Controls.Add(this.POsSearchTextBox);
            this.BotPOsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotPOsPanel.Location = new System.Drawing.Point(0, 531);
            this.BotPOsPanel.Name = "BotPOsPanel";
            this.BotPOsPanel.Size = new System.Drawing.Size(1050, 35);
            this.BotPOsPanel.TabIndex = 10;
            // 
            // POsSearchLabel
            // 
            this.POsSearchLabel.AutoSize = true;
            this.POsSearchLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.POsSearchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.POsSearchLabel.Location = new System.Drawing.Point(576, 4);
            this.POsSearchLabel.Name = "POsSearchLabel";
            this.POsSearchLabel.Size = new System.Drawing.Size(67, 23);
            this.POsSearchLabel.TabIndex = 20;
            this.POsSearchLabel.Text = "Поиск:";
            // 
            // POsBotLabel
            // 
            this.POsBotLabel.AutoSize = true;
            this.POsBotLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.POsBotLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.POsBotLabel.Location = new System.Drawing.Point(10, 6);
            this.POsBotLabel.Name = "POsBotLabel";
            this.POsBotLabel.Size = new System.Drawing.Size(103, 23);
            this.POsBotLabel.TabIndex = 3;
            this.POsBotLabel.Text = "Список ПО";
            // 
            // POsSearchTextBox
            // 
            this.POsSearchTextBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.POsSearchTextBox.Location = new System.Drawing.Point(646, 3);
            this.POsSearchTextBox.Name = "POsSearchTextBox";
            this.POsSearchTextBox.Size = new System.Drawing.Size(238, 27);
            this.POsSearchTextBox.TabIndex = 19;
            this.POsSearchTextBox.TextChanged += new System.EventHandler(this.POsSearchTextBox_TextChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle39.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle39.NullValue")));
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle39;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle40.NullValue")));
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle40;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // POsAddButton
            // 
            this.POsAddButton.Image = global::KursachFileSaving.Properties.Resources.PlusNormal;
            this.POsAddButton.ImageHover = global::KursachFileSaving.Properties.Resources.PlusHover;
            this.POsAddButton.ImageNormal = global::KursachFileSaving.Properties.Resources.PlusNormal;
            this.POsAddButton.Location = new System.Drawing.Point(1019, 4);
            this.POsAddButton.Name = "POsAddButton";
            this.POsAddButton.Size = new System.Drawing.Size(28, 28);
            this.POsAddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.POsAddButton.TabIndex = 10;
            this.POsAddButton.TabStop = false;
            this.POsAddButton.Click += new System.EventHandler(this.POsAddButton_Click);
            // 
            // POControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 566);
            this.Controls.Add(this.DGVPOs);
            this.Controls.Add(this.BotPOsPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POControl";
            this.Text = "POControl";
            ((System.ComponentModel.ISupportInitialize)(this.DGVPOs)).EndInit();
            this.BotPOsPanel.ResumeLayout(false);
            this.BotPOsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.POsAddButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGVPOs;
        private Parts.CustomerButton POsAddButton;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel BotPOsPanel;
        private System.Windows.Forms.Label POsSearchLabel;
        private System.Windows.Forms.Label POsBotLabel;
        public System.Windows.Forms.TextBox POsSearchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockCode;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}