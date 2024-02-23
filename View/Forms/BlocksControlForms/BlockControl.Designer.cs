namespace KursachFileSaving.View.Forms.BlocksControlForms
{
    partial class BlockControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlockControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVBlocks = new System.Windows.Forms.DataGridView();
            this.BotBlocksPanel = new System.Windows.Forms.Panel();
            this.BlocksSearchLabel = new System.Windows.Forms.Label();
            this.BlocksBotLabel = new System.Windows.Forms.Label();
            this.BlocksSearchTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motherboard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Videocard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.BlocksAddButton = new KursachFileSaving.View.Parts.CustomerButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBlocks)).BeginInit();
            this.BotBlocksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlocksAddButton)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVBlocks
            // 
            this.DGVBlocks.AllowUserToAddRows = false;
            this.DGVBlocks.AllowUserToDeleteRows = false;
            this.DGVBlocks.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBlocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DGVBlocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBlocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Code,
            this.Motherboard,
            this.RAM,
            this.Videocard,
            this.BlockName,
            this.POCode,
            this.Edit,
            this.Delete});
            this.DGVBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVBlocks.Location = new System.Drawing.Point(0, 0);
            this.DGVBlocks.Name = "DGVBlocks";
            this.DGVBlocks.ReadOnly = true;
            this.DGVBlocks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVBlocks.Size = new System.Drawing.Size(1050, 531);
            this.DGVBlocks.TabIndex = 11;
            this.DGVBlocks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBlocks_CellContentClick);
            // 
            // BotBlocksPanel
            // 
            this.BotBlocksPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.BotBlocksPanel.Controls.Add(this.BlocksAddButton);
            this.BotBlocksPanel.Controls.Add(this.BlocksSearchLabel);
            this.BotBlocksPanel.Controls.Add(this.BlocksBotLabel);
            this.BotBlocksPanel.Controls.Add(this.BlocksSearchTextBox);
            this.BotBlocksPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotBlocksPanel.Location = new System.Drawing.Point(0, 531);
            this.BotBlocksPanel.Name = "BotBlocksPanel";
            this.BotBlocksPanel.Size = new System.Drawing.Size(1050, 35);
            this.BotBlocksPanel.TabIndex = 10;
            // 
            // BlocksSearchLabel
            // 
            this.BlocksSearchLabel.AutoSize = true;
            this.BlocksSearchLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlocksSearchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BlocksSearchLabel.Location = new System.Drawing.Point(576, 4);
            this.BlocksSearchLabel.Name = "BlocksSearchLabel";
            this.BlocksSearchLabel.Size = new System.Drawing.Size(67, 23);
            this.BlocksSearchLabel.TabIndex = 20;
            this.BlocksSearchLabel.Text = "Поиск:";
            // 
            // BlocksBotLabel
            // 
            this.BlocksBotLabel.AutoSize = true;
            this.BlocksBotLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlocksBotLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BlocksBotLabel.Location = new System.Drawing.Point(10, 6);
            this.BlocksBotLabel.Name = "BlocksBotLabel";
            this.BlocksBotLabel.Size = new System.Drawing.Size(184, 23);
            this.BlocksBotLabel.TabIndex = 3;
            this.BlocksBotLabel.Text = "Список должностей";
            // 
            // BlocksSearchTextBox
            // 
            this.BlocksSearchTextBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlocksSearchTextBox.Location = new System.Drawing.Point(646, 3);
            this.BlocksSearchTextBox.Name = "BlocksSearchTextBox";
            this.BlocksSearchTextBox.Size = new System.Drawing.Size(238, 27);
            this.BlocksSearchTextBox.TabIndex = 19;
            this.BlocksSearchTextBox.TextChanged += new System.EventHandler(this.BlocksSearchTextBox_TextChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle23.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle23.NullValue")));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle23;
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
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle24.NullValue")));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 5;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Number.DefaultCellStyle = dataGridViewCellStyle14;
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 70;
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Code.DefaultCellStyle = dataGridViewCellStyle15;
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 55;
            // 
            // Motherboard
            // 
            this.Motherboard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Motherboard.DefaultCellStyle = dataGridViewCellStyle16;
            this.Motherboard.HeaderText = "Материнская плата";
            this.Motherboard.Name = "Motherboard";
            this.Motherboard.ReadOnly = true;
            this.Motherboard.Width = 136;
            // 
            // RAM
            // 
            this.RAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.RAM.DefaultCellStyle = dataGridViewCellStyle17;
            this.RAM.HeaderText = "RAM";
            this.RAM.Name = "RAM";
            this.RAM.ReadOnly = true;
            this.RAM.Width = 58;
            // 
            // Videocard
            // 
            this.Videocard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Videocard.DefaultCellStyle = dataGridViewCellStyle18;
            this.Videocard.HeaderText = "Видеокарта";
            this.Videocard.Name = "Videocard";
            this.Videocard.ReadOnly = true;
            this.Videocard.Width = 103;
            // 
            // BlockName
            // 
            this.BlockName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.BlockName.DefaultCellStyle = dataGridViewCellStyle19;
            this.BlockName.HeaderText = "Имя блока";
            this.BlockName.Name = "BlockName";
            this.BlockName.ReadOnly = true;
            // 
            // POCode
            // 
            this.POCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.POCode.DefaultCellStyle = dataGridViewCellStyle20;
            this.POCode.HeaderText = "Код ПО";
            this.POCode.Name = "POCode";
            this.POCode.ReadOnly = true;
            this.POCode.Width = 70;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle21.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle21.NullValue")));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle21;
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle22.NullValue")));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle22;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 5;
            // 
            // BlocksAddButton
            // 
            this.BlocksAddButton.Image = global::KursachFileSaving.Properties.Resources.PlusNormal;
            this.BlocksAddButton.ImageHover = global::KursachFileSaving.Properties.Resources.PlusHover;
            this.BlocksAddButton.ImageNormal = global::KursachFileSaving.Properties.Resources.PlusNormal;
            this.BlocksAddButton.Location = new System.Drawing.Point(1019, 3);
            this.BlocksAddButton.Name = "BlocksAddButton";
            this.BlocksAddButton.Size = new System.Drawing.Size(28, 28);
            this.BlocksAddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BlocksAddButton.TabIndex = 10;
            this.BlocksAddButton.TabStop = false;
            this.BlocksAddButton.Click += new System.EventHandler(this.BlocksAddButton_Click);
            // 
            // BlockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 566);
            this.Controls.Add(this.DGVBlocks);
            this.Controls.Add(this.BotBlocksPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BlockControl";
            this.Text = "BlockControl";
            ((System.ComponentModel.ISupportInitialize)(this.DGVBlocks)).EndInit();
            this.BotBlocksPanel.ResumeLayout(false);
            this.BotBlocksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlocksAddButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGVBlocks;
        private System.Windows.Forms.Panel BotBlocksPanel;
        private Parts.CustomerButton BlocksAddButton;
        private System.Windows.Forms.Label BlocksSearchLabel;
        private System.Windows.Forms.Label BlocksBotLabel;
        public System.Windows.Forms.TextBox BlocksSearchTextBox;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motherboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Videocard;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn POCode;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}