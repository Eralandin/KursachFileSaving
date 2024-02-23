namespace KursachFileSaving.View.Forms.EmpControlForms
{
    partial class EmpControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.EmpsAddButton = new KursachFileSaving.View.Parts.CustomerButton();
            this.EmpsSearchLabel = new System.Windows.Forms.Label();
            this.EmpsBotLabel = new System.Windows.Forms.Label();
            this.EmpsSearchTextBox = new System.Windows.Forms.TextBox();
            this.BotEmpsPanel = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.BlockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Videocard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motherboard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVEmps = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EmpsAddButton)).BeginInit();
            this.BotEmpsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmps)).BeginInit();
            this.SuspendLayout();
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
            // EmpsAddButton
            // 
            this.EmpsAddButton.Image = global::KursachFileSaving.Properties.Resources.PlusNormal;
            this.EmpsAddButton.ImageHover = global::KursachFileSaving.Properties.Resources.PlusHover;
            this.EmpsAddButton.ImageNormal = global::KursachFileSaving.Properties.Resources.PlusNormal;
            this.EmpsAddButton.Location = new System.Drawing.Point(1019, 3);
            this.EmpsAddButton.Name = "EmpsAddButton";
            this.EmpsAddButton.Size = new System.Drawing.Size(28, 28);
            this.EmpsAddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmpsAddButton.TabIndex = 10;
            this.EmpsAddButton.TabStop = false;
            // 
            // EmpsSearchLabel
            // 
            this.EmpsSearchLabel.AutoSize = true;
            this.EmpsSearchLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmpsSearchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmpsSearchLabel.Location = new System.Drawing.Point(576, 4);
            this.EmpsSearchLabel.Name = "EmpsSearchLabel";
            this.EmpsSearchLabel.Size = new System.Drawing.Size(67, 23);
            this.EmpsSearchLabel.TabIndex = 20;
            this.EmpsSearchLabel.Text = "Поиск:";
            // 
            // EmpsBotLabel
            // 
            this.EmpsBotLabel.AutoSize = true;
            this.EmpsBotLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmpsBotLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmpsBotLabel.Location = new System.Drawing.Point(10, 6);
            this.EmpsBotLabel.Name = "EmpsBotLabel";
            this.EmpsBotLabel.Size = new System.Drawing.Size(184, 23);
            this.EmpsBotLabel.TabIndex = 3;
            this.EmpsBotLabel.Text = "Список должностей";
            // 
            // EmpsSearchTextBox
            // 
            this.EmpsSearchTextBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmpsSearchTextBox.Location = new System.Drawing.Point(646, 3);
            this.EmpsSearchTextBox.Name = "EmpsSearchTextBox";
            this.EmpsSearchTextBox.Size = new System.Drawing.Size(238, 27);
            this.EmpsSearchTextBox.TabIndex = 19;
            // 
            // BotEmpsPanel
            // 
            this.BotEmpsPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.BotEmpsPanel.Controls.Add(this.EmpsAddButton);
            this.BotEmpsPanel.Controls.Add(this.EmpsSearchLabel);
            this.BotEmpsPanel.Controls.Add(this.EmpsBotLabel);
            this.BotEmpsPanel.Controls.Add(this.EmpsSearchTextBox);
            this.BotEmpsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotEmpsPanel.Location = new System.Drawing.Point(0, 531);
            this.BotEmpsPanel.Name = "BotEmpsPanel";
            this.BotEmpsPanel.Size = new System.Drawing.Size(1050, 35);
            this.BotEmpsPanel.TabIndex = 12;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 5;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle4;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 5;
            // 
            // BlockName
            // 
            this.BlockName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.BlockName.DefaultCellStyle = dataGridViewCellStyle5;
            this.BlockName.HeaderText = "Имя блока";
            this.BlockName.Name = "BlockName";
            this.BlockName.ReadOnly = true;
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
            this.Videocard.Width = 103;
            // 
            // RAM
            // 
            this.RAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.RAM.DefaultCellStyle = dataGridViewCellStyle7;
            this.RAM.HeaderText = "RAM";
            this.RAM.Name = "RAM";
            this.RAM.ReadOnly = true;
            this.RAM.Width = 58;
            // 
            // Motherboard
            // 
            this.Motherboard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Motherboard.DefaultCellStyle = dataGridViewCellStyle8;
            this.Motherboard.HeaderText = "Материнская плата";
            this.Motherboard.Name = "Motherboard";
            this.Motherboard.ReadOnly = true;
            this.Motherboard.Width = 136;
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Code.DefaultCellStyle = dataGridViewCellStyle9;
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 55;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Number.DefaultCellStyle = dataGridViewCellStyle10;
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 70;
            // 
            // POCode
            // 
            this.POCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.POCode.DefaultCellStyle = dataGridViewCellStyle11;
            this.POCode.HeaderText = "Код ПО";
            this.POCode.Name = "POCode";
            this.POCode.ReadOnly = true;
            this.POCode.Width = 70;
            // 
            // DGVEmps
            // 
            this.DGVEmps.AllowUserToAddRows = false;
            this.DGVEmps.AllowUserToDeleteRows = false;
            this.DGVEmps.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVEmps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DGVEmps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Code,
            this.Motherboard,
            this.RAM,
            this.Videocard,
            this.BlockName,
            this.POCode,
            this.Edit,
            this.Delete});
            this.DGVEmps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVEmps.Location = new System.Drawing.Point(0, 0);
            this.DGVEmps.Name = "DGVEmps";
            this.DGVEmps.ReadOnly = true;
            this.DGVEmps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVEmps.Size = new System.Drawing.Size(1050, 566);
            this.DGVEmps.TabIndex = 13;
            // 
            // EmpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 566);
            this.Controls.Add(this.BotEmpsPanel);
            this.Controls.Add(this.DGVEmps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpControl";
            this.Text = "EmpControl";
            ((System.ComponentModel.ISupportInitialize)(this.EmpsAddButton)).EndInit();
            this.BotEmpsPanel.ResumeLayout(false);
            this.BotEmpsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Parts.CustomerButton EmpsAddButton;
        private System.Windows.Forms.Label EmpsSearchLabel;
        private System.Windows.Forms.Label EmpsBotLabel;
        public System.Windows.Forms.TextBox EmpsSearchTextBox;
        private System.Windows.Forms.Panel BotEmpsPanel;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Videocard;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motherboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn POCode;
        public System.Windows.Forms.DataGridView DGVEmps;
    }
}