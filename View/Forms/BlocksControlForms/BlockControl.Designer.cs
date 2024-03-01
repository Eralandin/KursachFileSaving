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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlockControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVBlocks = new System.Windows.Forms.DataGridView();
            this.BotBlocksPanel = new System.Windows.Forms.Panel();
            this.BlocksAddButton = new KursachFileSaving.View.Parts.CustomerButton();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBlocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.BlocksBotLabel.Size = new System.Drawing.Size(140, 23);
            this.BlocksBotLabel.TabIndex = 3;
            this.BlocksBotLabel.Text = "Список блоков";
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
            dataGridViewCellStyle11.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle11.NullValue")));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle12.NullValue")));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle12;
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
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Code.DefaultCellStyle = dataGridViewCellStyle3;
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Code.Width = 36;
            // 
            // Motherboard
            // 
            this.Motherboard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Motherboard.DefaultCellStyle = dataGridViewCellStyle4;
            this.Motherboard.HeaderText = "Материнская плата";
            this.Motherboard.Name = "Motherboard";
            this.Motherboard.ReadOnly = true;
            this.Motherboard.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Motherboard.Width = 117;
            // 
            // RAM
            // 
            this.RAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.RAM.DefaultCellStyle = dataGridViewCellStyle5;
            this.RAM.HeaderText = "RAM";
            this.RAM.Name = "RAM";
            this.RAM.ReadOnly = true;
            this.RAM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RAM.Width = 39;
            // 
            // Videocard
            // 
            this.Videocard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Videocard.DefaultCellStyle = dataGridViewCellStyle6;
            this.Videocard.HeaderText = "Видеокарта";
            this.Videocard.Name = "Videocard";
            this.Videocard.ReadOnly = true;
            this.Videocard.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Videocard.Width = 84;
            // 
            // BlockName
            // 
            this.BlockName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.BlockName.DefaultCellStyle = dataGridViewCellStyle7;
            this.BlockName.HeaderText = "Имя блока";
            this.BlockName.Name = "BlockName";
            this.BlockName.ReadOnly = true;
            this.BlockName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // POCode
            // 
            this.POCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.POCode.DefaultCellStyle = dataGridViewCellStyle8;
            this.POCode.HeaderText = "Код ПО";
            this.POCode.Name = "POCode";
            this.POCode.ReadOnly = true;
            this.POCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.POCode.Width = 51;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle9.NullValue")));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle10.NullValue")));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle10;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 5;
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