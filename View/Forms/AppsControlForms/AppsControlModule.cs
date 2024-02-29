using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.Presenter;
using KursachFileSaving.View.Forms.ConfirmationForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.View.Forms.AppsControlForms
{
    public partial class AppsControlModule : Form, IACMView
    {
        private readonly AppsControlModulePresenter _presenter;
        public List<WorkType> workTypesList;
        public List<Blocks> blocksList;
        public AppsControlModule(List<Apps> appsData, int rowtoedit)
        {
            InitializeComponent();
            blocksList = JsonFileManager.LoadData().Item2;
            workTypesList = JsonFileManager.LoadData().Item7;
            _presenter = new AppsControlModulePresenter(this, appsData, rowtoedit);
            foreach (Blocks block in blocksList)
            {
                comboBox1.Items.Add(block.BlockCode);
            }
            foreach (WorkType wt in workTypesList)
            {
                comboBox2.Items.Add(wt.WorkTypeCode + ". " + wt.WorkTypeName);
            }
        }
        public string AppCode { get => AppCodeTextBox.Text; set => AppCodeTextBox.Text = value; }
        public string AppComment { get => AppCommTextBox.Text; set => AppCommTextBox.Text = value; }
        public string Day { get => textBox1.Text; set => textBox1.Text = value; }
        public string Month { get => textBox2.Text; set => textBox2.Text = value; }
        public string Year { get => textBox3.Text; set => textBox3.Text = value; }
        public string BlockCode { get => comboBox1.Text; set => comboBox1.Text = value; }
        public string WorkType { get => comboBox2.Text; set => comboBox2.Text = value; }

        public event EventHandler SaveApp;
        public event EventHandler UpdateApp;
        public event EventHandler Cancel;
        public event EventHandler<SearchEventArgs> SearchTextChanged;
        public event EventHandler<string> MessageForm;
        public void MessageFormView(string message)
        {
            MessageForm mf = new MessageForm(message);
            mf.ShowDialog();
        }
        public void CloseForm()
        {
            OperationConfirmedForm ocf = new OperationConfirmedForm();
            ocf.ShowDialog();
            this.Close();
        }

        private void ACMCancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ACMUpdateButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите обновить эту заявку?", "Обновление заявки", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UpdateApp?.Invoke(this, EventArgs.Empty);
            }
        }

        private void ACMSaveButton_Click(object sender, EventArgs e)
        {
            SaveApp?.Invoke(this, EventArgs.Empty);
        }
    }
}
