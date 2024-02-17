namespace KursachFileSaving.View.Forms.WorkTypesForms
{
    partial class WorkTypesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkTypesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BotWTsPanel = new System.Windows.Forms.Panel();
            this.WTsSearchLabel = new System.Windows.Forms.Label();
            this.WorkTypesLabel = new System.Windows.Forms.Label();
            this.WTsSearchTextBox = new System.Windows.Forms.TextBox();
            this.DGVWTsForm = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commentary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.BotWTsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVWTsForm)).BeginInit();
            this.SuspendLayout();
            // 
            // BotWTsPanel
            // 
            this.BotWTsPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.BotWTsPanel.Controls.Add(this.WTsSearchLabel);
            this.BotWTsPanel.Controls.Add(this.WorkTypesLabel);
            this.BotWTsPanel.Controls.Add(this.WTsSearchTextBox);
            this.BotWTsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotWTsPanel.Location = new System.Drawing.Point(0, 521);
            this.BotWTsPanel.Name = "BotWTsPanel";
            this.BotWTsPanel.Size = new System.Drawing.Size(965, 35);
            this.BotWTsPanel.TabIndex = 6;
            // 
            // WTsSearchLabel
            // 
            this.WTsSearchLabel.AutoSize = true;
            this.WTsSearchLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WTsSearchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WTsSearchLabel.Location = new System.Drawing.Point(576, 4);
            this.WTsSearchLabel.Name = "WTsSearchLabel";
            this.WTsSearchLabel.Size = new System.Drawing.Size(67, 23);
            this.WTsSearchLabel.TabIndex = 20;
            this.WTsSearchLabel.Text = "Поиск:";
            // 
            // WorkTypesLabel
            // 
            this.WorkTypesLabel.AutoSize = true;
            this.WorkTypesLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkTypesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WorkTypesLabel.Location = new System.Drawing.Point(10, 6);
            this.WorkTypesLabel.Name = "WorkTypesLabel";
            this.WorkTypesLabel.Size = new System.Drawing.Size(185, 23);
            this.WorkTypesLabel.TabIndex = 3;
            this.WorkTypesLabel.Text = "Список типов работ";
            // 
            // WTsSearchTextBox
            // 
            this.WTsSearchTextBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WTsSearchTextBox.Location = new System.Drawing.Point(646, 3);
            this.WTsSearchTextBox.Name = "WTsSearchTextBox";
            this.WTsSearchTextBox.Size = new System.Drawing.Size(238, 27);
            this.WTsSearchTextBox.TabIndex = 19;
            // 
            // DGVWTsForm
            // 
            this.DGVWTsForm.AllowUserToAddRows = false;
            this.DGVWTsForm.AllowUserToDeleteRows = false;
            this.DGVWTsForm.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVWTsForm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVWTsForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVWTsForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Code,
            this.WorkName,
            this.Commentary,
            this.Edit,
            this.Delete});
            this.DGVWTsForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVWTsForm.Location = new System.Drawing.Point(0, 0);
            this.DGVWTsForm.Name = "DGVWTsForm";
            this.DGVWTsForm.ReadOnly = true;
            this.DGVWTsForm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVWTsForm.Size = new System.Drawing.Size(965, 521);
            this.DGVWTsForm.TabIndex = 7;
            this.DGVWTsForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVWTsForm_CellContentClick);
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
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Code.DefaultCellStyle = dataGridViewCellStyle3;
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 61;
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
            // Commentary
            // 
            this.Commentary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Commentary.DefaultCellStyle = dataGridViewCellStyle5;
            this.Commentary.HeaderText = "Commentary";
            this.Commentary.Name = "Commentary";
            this.Commentary.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle6;
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
            // WorkTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 556);
            this.Controls.Add(this.DGVWTsForm);
            this.Controls.Add(this.BotWTsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkTypesForm";
            this.Text = "WorkTypesForm";
            this.BotWTsPanel.ResumeLayout(false);
            this.BotWTsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVWTsForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BotWTsPanel;
        private System.Windows.Forms.Label WTsSearchLabel;
        private System.Windows.Forms.Label WorkTypesLabel;
        public System.Windows.Forms.TextBox WTsSearchTextBox;
        private System.Windows.Forms.DataGridView DGVWTsForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commentary;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}