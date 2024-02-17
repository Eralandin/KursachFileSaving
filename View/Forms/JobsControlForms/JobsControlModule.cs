using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.Presenter;

namespace KursachFileSaving.View.Forms.JobsControlForms
{
    public partial class JobsControlModule : Form, IJobsControlModuleView
    {
        private readonly JobsControlModulePresenter _presenter;
        public JobsControlModule(List<Jobs> jobsData, int rowtoedit)
        {
            InitializeComponent();
            _presenter = new JobsControlModulePresenter(this, jobsData, rowtoedit);
        }

        public string JobCode { get => JobCodeTextBox.Text; set => JobCodeTextBox.Text = value; }
        public string JobName { get => JobNameTextBox.Text; set => JobNameTextBox.Text = value; }

        public event EventHandler SaveJob;
        public event EventHandler UpdateJob;
        public event EventHandler Cancel;

        private void JCMCancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void JCMSaveButton_Click(object sender, EventArgs e)
        {
            SaveJob?.Invoke(this, EventArgs.Empty);
        }
        public void CloseForm()
        {
            this.Close();
        }

        private void JCMUpdateButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите обновить эту должность?", "Обновление должности", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UpdateJob?.Invoke(this, EventArgs.Empty);
            } 
        }
    }
}
