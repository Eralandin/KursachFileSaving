﻿using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.View.Forms.ConfirmationForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachFileSaving.Presenter
{
    public class JobsControlModulePresenter
    {
        private readonly IJobsControlModuleView _view;
        private List<Jobs> _JobsData; // Список должностей, загруженных из JSON-файла
        public int RowToEdit;

        public JobsControlModulePresenter(IJobsControlModuleView view, List<Jobs> jobsData, int rowtoedit)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _JobsData = jobsData;
            _view.SaveJob += SaveJob;
            _view.UpdateJob += UpdateJob;
            _view.MessageForm += MessageFormCreate;
            RowToEdit = rowtoedit;
        }
        private void MessageFormCreate(object sender, string message)
        {
            MessageForm mf = new MessageForm(message);
            mf.ShowDialog();
        }

        private void SaveJob(object sender, EventArgs e)
        {
            try
            {
                // Логика сохранения новой должности
                // Проверка введенных данных

                // Создание новой должности
                Jobs newJob = new Jobs
                {
                    // Присваивание значений из представления
                    JobCode = int.Parse(_view.JobCode),
                    JobName = _view.JobName
                };
                // Добавление новой должности в список
                _JobsData.Add(newJob);

                JsonFileManager.SaveJobs(_JobsData, "data.json");

                // Закрытие формы после сохранения
                _view.CloseForm();
            }
            catch (ArgumentException ex)
            {
                MessageFormCreate(this, "Ошибка!" + ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageFormCreate(this, "Непредвиденная ошибка!" + ex.Message);
                return;
            }
        }

        private void UpdateJob(object sender, EventArgs e)
        {
            try
            {
                // Логика обновления выбранной должности
                Jobs updatedjob = new Jobs
                {
                    JobCode = int.Parse(_view.JobCode),
                    JobName = _view.JobName
                };
                _JobsData.RemoveAt(RowToEdit);
                _JobsData.Insert(RowToEdit, updatedjob);
                JsonFileManager.SaveJobs(_JobsData, "data.json");
                _view.CloseForm();
            }
            catch (ArgumentException ex)
            {
                MessageFormCreate(this, "Ошибка!" + ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageFormCreate(this, "Непредвиденная ошибка!" + ex.Message);
                return;
            }
        }
    }
}
