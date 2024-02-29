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

namespace KursachFileSaving.View.Forms.EmpControlForms
{
    public partial class EmpControlModule : Form, IECMView
    {
        private readonly EmpControlModulePresenter _presenter;
        public List<Jobs> jobsList;
        public List<Blocks> blocksList;
        public EmpControlModule(List<Employees> empsData, int rowtoedit)
        {
            InitializeComponent();
            jobsList = JsonFileManager.LoadData().Item4;
            blocksList = JsonFileManager.LoadData().Item2;
            _presenter = new EmpControlModulePresenter(this, empsData, blocksList, rowtoedit, jobsList);
            ShowJobs(jobsList);
            foreach (Jobs job in jobsList)
            {
                JobCodeCombobox.Items.Add(job.JobCode);
            }
            comboBox1.Items.Add(0);
            foreach (Blocks block in blocksList)
            {
                comboBox1.Items.Add(block.BlockCode);
            }
        }
        public string EmpCode { get => EmpCodeTextBox.Text; set => EmpCodeTextBox.Text = value; }
        public string LastName { get => EmpLastnameTextBox.Text; set => EmpLastnameTextBox.Text = value; }
        public string FirstName { get => EmpNameTextBox.Text; set => EmpNameTextBox.Text = value; }
        public string Patronymic { get => EmpPatronymicTextBox.Text; set => EmpPatronymicTextBox.Text = value; }
        public string Email { get => EmpEmailTextBox.Text; set => EmpEmailTextBox.Text = value; }
        public string Login { get => EmpLoginTextBox.Text; set => EmpLoginTextBox.Text = value; }
        public string Password { get => EmpPasswordTextBox.Text; set => EmpPasswordTextBox.Text = value; }
        public string JobCode { get => JobCodeCombobox.Text; set => JobCodeCombobox.Text = value; }
        public string BlockCode { get => comboBox1.Text; set => comboBox1.Text = value; }

        public event EventHandler SaveEmp;
        public event EventHandler UpdateEmp;
        public event EventHandler Cancel;
        public event EventHandler<SearchEventArgs> SearchTextChanged;
        public event EventHandler<string> MessageForm;
        public string SearchText => DGVECMJobsSearchTextBox.Text;
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

        private void ECMCancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ECMSaveButton_Click(object sender, EventArgs e)
        {
            SaveEmp?.Invoke(this, EventArgs.Empty);
        }

        private void ECMUpdateButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите обновить этого сотрудника?", "Обновление сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UpdateEmp?.Invoke(this, EventArgs.Empty);
            }
        }

        private void DGVECMJobsSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchTextChanged?.Invoke(this, new SearchEventArgs(DGVECMJobsSearchTextBox.Text));
        }
        public void ShowJobs(List<Jobs> jobsList)
        {
            if (jobsList.Count == 0)
            {
                DGVECMJobs.Rows.Clear();
            }
            else
            {
                DGVECMJobs.Rows.Clear();
                for (int i = 0; i < jobsList.Count; i++)
                {
                    DGVECMJobs.Rows.Add(i + 1, jobsList[i].JobCode, jobsList[i].JobName);
                }
            }
        }
    }
}
