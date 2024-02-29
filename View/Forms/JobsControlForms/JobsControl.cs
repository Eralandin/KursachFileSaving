using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.Presenter;
using KursachFileSaving.View.Forms.ConfirmationForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KursachFileSaving.View.Forms.JobsControlForms
{
    public partial class JobsControl : Form, IJobsControlView
    {
        private readonly JobControlPresenter _presenter;

        public JobsControl(List<Jobs> jobslist)
        {
            SuspendLayout();
            InitializeComponent();
            _presenter = new JobControlPresenter(this, jobslist);
            ShowJobs(jobslist);
            ResumeLayout(true);
        }
        public class SearchEventArgs : EventArgs
        {
            public string SearchText { get; }

            public SearchEventArgs(string searchText)
            {
                SearchText = searchText;
            }
        }

        public event EventHandler Load;
        public event EventHandler AddJob;
        public event EventHandler UpdateJob;
        public event EventHandler DeleteJob;
        public event EventHandler<string> MessageForm;
        public event EventHandler<SearchEventArgs> SearchTextChanged;

        public string SearchText => JobsSearchTextBox.Text;

        public void ShowJobs(List<Jobs> jobs)
        {
            if (jobs.Count == 0)
            {
                DGVJobs.Rows.Clear();
            }
            else
            {
                DGVJobs.Rows.Clear();
                for (int i = 0; i < jobs.Count; i++)
                {
                    DGVJobs.Rows.Add(i + 1, jobs[i].JobCode, jobs[i].JobName);
                }
            }
        }

        private void DGVJobs_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = DGVJobs.Columns[e.ColumnIndex].Name;
                if (colName == "Edit")
                {
                    // Логика редактирования должности
                    _presenter.RowToEdit = e.RowIndex;
                    UpdateJob?.Invoke(sender, e);
                }
                else if (colName == "Delete")
                {
                    if (MessageBox.Show("Вы уверены, что хотите удалить эту должность?", "Удаление должности", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Логика удаления должности
                        _presenter.RowToDelete = e.RowIndex;
                        DeleteJob?.Invoke(sender, e);
                    }
                }
            }
        }

        private void JobsAddButton_Click(object sender, EventArgs e)
        {
            AddJob?.Invoke(sender, e);
        }

        private void JobsSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            // Получаем текст из текстового поля
            string searchText = JobsSearchTextBox.Text;

            // Вызываем событие поиска и передаем текст для поиска
            SearchTextChanged?.Invoke(this, new SearchEventArgs(JobsSearchTextBox.Text));
        }
    }
}
