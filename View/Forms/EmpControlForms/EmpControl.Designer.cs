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
            this.BotBlocksPanel = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.DGVEmps = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpJobCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpWorkCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpAppCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpBlockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EmpsAddButton)).BeginInit();
            this.BotBlocksPanel.SuspendLayout();
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
            this.EmpsBotLabel.Size = new System.Drawing.Size(189, 23);
            this.EmpsBotLabel.TabIndex = 3;
            this.EmpsBotLabel.Text = "Список сотрудников";
            // 
            // EmpsSearchTextBox
            // 
            this.EmpsSearchTextBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmpsSearchTextBox.Location = new System.Drawing.Point(646, 3);
            this.EmpsSearchTextBox.Name = "EmpsSearchTextBox";
            this.EmpsSearchTextBox.Size = new System.Drawing.Size(238, 27);
            this.EmpsSearchTextBox.TabIndex = 19;
            // 
            // BotBlocksPanel
            // 
            this.BotBlocksPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.BotBlocksPanel.Controls.Add(this.EmpsAddButton);
            this.BotBlocksPanel.Controls.Add(this.EmpsSearchLabel);
            this.BotBlocksPanel.Controls.Add(this.EmpsBotLabel);
            this.BotBlocksPanel.Controls.Add(this.EmpsSearchTextBox);
            this.BotBlocksPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotBlocksPanel.Location = new System.Drawing.Point(0, 531);
            this.BotBlocksPanel.Name = "BotBlocksPanel";
            this.BotBlocksPanel.Size = new System.Drawing.Size(1050, 35);
            this.BotBlocksPanel.TabIndex = 12;
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
            // DGVEmps
            // 
            this.DGVEmps.AllowUserToAddRows = false;
            this.DGVEmps.AllowUserToDeleteRows = false;
            this.DGVEmps.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVEmps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVEmps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.EmployeeCode,
            this.EmpLastName,
            this.EmpName,
            this.EmpPatronymic,
            this.EmpLogin,
            this.EmpEmail,
            this.EmpJobCode,
            this.EmpWorkCode,
            this.EmpAppCode,
            this.EmpBlockCode,
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
            this.Number.Width = 70;
            // 
            // EmployeeCode
            // 
            this.EmployeeCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.EmployeeCode.DefaultCellStyle = dataGridViewCellStyle5;
            this.EmployeeCode.HeaderText = "Код сотрудника";
            this.EmployeeCode.Name = "EmployeeCode";
            this.EmployeeCode.ReadOnly = true;
            this.EmployeeCode.Width = 115;
            // 
            // EmpLastName
            // 
            this.EmpLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.EmpLastName.DefaultCellStyle = dataGridViewCellStyle6;
            this.EmpLastName.HeaderText = "Фамилия сотрудника";
            this.EmpLastName.Name = "EmpLastName";
            this.EmpLastName.ReadOnly = true;
            this.EmpLastName.Width = 5;
            // 
            // EmpName
            // 
            this.EmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.EmpName.DefaultCellStyle = dataGridViewCellStyle7;
            this.EmpName.HeaderText = "Имя Сотрудника";
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            this.EmpName.Width = 5;
            // 
            // EmpPatronymic
            // 
            this.EmpPatronymic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.EmpPatronymic.DefaultCellStyle = dataGridViewCellStyle8;
            this.EmpPatronymic.HeaderText = "Отчество сотрудника";
            this.EmpPatronymic.Name = "EmpPatronymic";
            this.EmpPatronymic.ReadOnly = true;
            this.EmpPatronymic.Width = 5;
            // 
            // EmpLogin
            // 
            this.EmpLogin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.EmpLogin.DefaultCellStyle = dataGridViewCellStyle9;
            this.EmpLogin.HeaderText = "Логин сотрудника";
            this.EmpLogin.Name = "EmpLogin";
            this.EmpLogin.ReadOnly = true;
            this.EmpLogin.Width = 5;
            // 
            // EmpEmail
            // 
            this.EmpEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.EmpEmail.DefaultCellStyle = dataGridViewCellStyle10;
            this.EmpEmail.HeaderText = "E-mail сотрудника";
            this.EmpEmail.Name = "EmpEmail";
            this.EmpEmail.ReadOnly = true;
            this.EmpEmail.Width = 5;
            // 
            // EmpJobCode
            // 
            this.EmpJobCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmpJobCode.HeaderText = "Код должности";
            this.EmpJobCode.Name = "EmpJobCode";
            this.EmpJobCode.ReadOnly = true;
            this.EmpJobCode.Width = 112;
            // 
            // EmpWorkCode
            // 
            this.EmpWorkCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmpWorkCode.HeaderText = "Код типа работы";
            this.EmpWorkCode.Name = "EmpWorkCode";
            this.EmpWorkCode.ReadOnly = true;
            this.EmpWorkCode.Width = 121;
            // 
            // EmpAppCode
            // 
            this.EmpAppCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmpAppCode.HeaderText = "Код заявки";
            this.EmpAppCode.Name = "EmpAppCode";
            this.EmpAppCode.ReadOnly = true;
            this.EmpAppCode.Width = 91;
            // 
            // EmpBlockCode
            // 
            this.EmpBlockCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmpBlockCode.HeaderText = "Код блока";
            this.EmpBlockCode.Name = "EmpBlockCode";
            this.EmpBlockCode.ReadOnly = true;
            this.EmpBlockCode.Width = 86;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle11.NullValue")));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle12.NullValue")));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle12;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 5;
            // 
            // ECM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 566);
            this.Controls.Add(this.BotBlocksPanel);
            this.Controls.Add(this.DGVEmps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ECM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECM";
            ((System.ComponentModel.ISupportInitialize)(this.EmpsAddButton)).EndInit();
            this.BotBlocksPanel.ResumeLayout(false);
            this.BotBlocksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Parts.CustomerButton EmpsAddButton;
        private System.Windows.Forms.Label EmpsSearchLabel;
        private System.Windows.Forms.Label EmpsBotLabel;
        public System.Windows.Forms.TextBox EmpsSearchTextBox;
        private System.Windows.Forms.Panel BotBlocksPanel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public System.Windows.Forms.DataGridView DGVEmps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpPatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpJobCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpWorkCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpAppCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpBlockCode;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}