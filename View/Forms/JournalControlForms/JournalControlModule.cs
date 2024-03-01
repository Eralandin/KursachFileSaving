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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KursachFileSaving.View.Forms.JournalControlForms
{
    public partial class JournalControlModule : Form, IJournalControlModuleView
    {
        private readonly JournalControlModulePresenter _presenter;
        public List<Apps> appsList;
        public JournalControlModule(List<Journal> journalData)
        {
            InitializeComponent();
            appsList = JsonFileManager.LoadData().Item1;
            _presenter = new JournalControlModulePresenter(this, journalData);
            foreach (var app in appsList)
            {
                AppCodeComboBox.Items.Add(app.AppCode);
            }
        }
        public string RecordCode { get => RecordCodeTextBox.Text; set => RecordCodeTextBox.Text = value; }
        public string AppCode { get => AppCodeComboBox.Text; set => AppCodeComboBox.Text = value; }
        public string Commentary { get => richTextBox1.Text; set => richTextBox1.Text = value; }
        public string Date { get => DateBeginTextBox.Text; set => DateBeginTextBox.Text = value; }
        public string BlockCode { get => BlockCodeTextBox.Text; set => BlockCodeTextBox.Text = value; }
        public string WorkCode { get => WorkTypeTextBox.Text; set => WorkTypeTextBox.Text = value; }
        public string DateOfEnd { get => DateEndTextBox.Text; set => DateEndTextBox.Text = value; }

        public event EventHandler SaveJournal;
        public event EventHandler<int> CheckApp;
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

        private void JCMSaveButton_Click(object sender, EventArgs e)
        {
            SaveJournal?.Invoke(this, EventArgs.Empty);
        }

        private void JCMCancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AppCodeComboBox.Text != "")
                {
                    CheckApp?.Invoke(this, int.Parse(AppCodeComboBox.Text));
                }
                else
                {
                    throw new ArgumentNullException("Ошибка ввода кода заявки! Проверьте ввод!");
                }
            }
            catch (Exception ex)
            {
                MessageFormView("Ошибка! " + ex.Message);
            }
        }
    }
}
