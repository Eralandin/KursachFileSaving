using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.View.Forms.ConfirmationForms;
using KursachFileSaving.View.Forms.JobsControlForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Presenter
{
    public class JobControlPresenter
    {
        private readonly IJobsControlView _view;
        private List<Jobs> JobsList;
        public int RowToDelete;
        public int RowToEdit;

        public JobControlPresenter(IJobsControlView view, List<Jobs> jobs)
        {
            JobsList = jobs;
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _view.Load += OnLoad;
            _view.AddJob += AddJob;
            _view.UpdateJob += UpdateJob;
            _view.DeleteJob += DeleteJob;
            _view.SearchTextChanged += OnSearch;
            _view.MessageForm += MessageFormCreate;
        }
        private void MessageFormCreate(object sender, string e)
        {
            MessageForm mf = new MessageForm(e);
            mf.ShowDialog();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            LoadJobs(JobsList);
        }

        private void LoadJobs(List<Jobs> jobs)
        {
            _view.ShowJobs(jobs);
        }

        public void AddJob(object sender, EventArgs e)
        {
            JobsControlModule moduleForm = new JobsControlModule(JobsList, RowToEdit);
            moduleForm.JCMUpdateButton.Enabled = false;
            if (JobsList.Count == 0)
            {
                moduleForm.JobCodeTextBox.Text = 1.ToString();
            }
            else
            {
                moduleForm.JobCodeTextBox.Text = (JobsList.Last().JobCode + 1).ToString();
            }
            moduleForm.JobCodeTextBox.Enabled = false;
            moduleForm.ShowDialog();
            LoadJobs(JobsList);
        }

        public void UpdateJob(object sender, EventArgs e)
        {
            JobsControlModule moduleForm = new JobsControlModule(JobsList, RowToEdit);
            moduleForm.JobCodeTextBox.Enabled = false;
            moduleForm.JobCodeTextBox.Text = JobsList[RowToEdit].JobCode.ToString();
            moduleForm.JobNameTextBox.Text = JobsList[RowToEdit].JobName.ToString();
            moduleForm.JCMSaveButton.Enabled = false;
            moduleForm.ShowDialog();
            LoadJobs(JobsList);
        }

        public void DeleteJob(object sender, EventArgs e)
        {
            try
            {
                JobsList.Remove(JobsList[RowToDelete]);
                JsonFileManager.SaveJobs(JobsList, "data.json");
                LoadJobs(JobsList);
            }
            catch (Exception ex)
            {
                MessageFormCreate(this, "Непредвиденная ошибка! " + ex.Message);
                return;
            }
        }
        private void OnSearch(object sender, SearchEventArgs e)
        {
            // Получаем текст запроса из аргумента события
            string searchText = e.SearchText;

            // Выполняем логику поиска по тексту запроса
            // Например, фильтруем список должностей по названию или коду
            List<Jobs> filteredJobs = JobsList.Where(job => job.JobName.Contains(searchText) || job.JobCode.ToString().Contains(searchText)).ToList();

            // Обновляем представление с отфильтрованным списком должностей
            _view.ShowJobs(filteredJobs);
        }
    }
}
