using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.View.Forms.AppsControlForms;
using KursachFileSaving.View.Forms.ConfirmationForms;
using KursachFileSaving.View.Forms.EmpControlForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Presenter
{
    internal class AppsControlPresenter
    {
        private readonly IACView _view;
        private List<Apps> _appsList;

        public int RowToDelete;
        public int RowToEdit;
        public AppsControlPresenter(IACView view, List<Apps> appsList)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _appsList = appsList;

            _view.Load += OnLoad;
            _view.AddApp += AddApp;
            _view.UpdateApp += UpdateApp;
            _view.DeleteApp += DeleteApp;
            _view.SearchTextChanged += OnSearch;
            _view.MessageForm += MessageFormCreate;
        }
        private void MessageFormCreate(object sender, string message)
        {
            MessageForm mf = new MessageForm(message);
            mf.ShowDialog();
        }
        private void OnLoad(object sender, EventArgs e)
        {
            LoadApps(_appsList);
        }
        private void LoadApps(List<Apps> appsList)
        {
            _view.ShowApps(appsList);
        }
        public void AddApp(object sender, EventArgs e)
        {
            try
            {
                AppsControlModule moduleForm = new AppsControlModule(_appsList, RowToEdit);
                moduleForm.ACMUpdateButton.Enabled = false;
                if (_appsList.Count == 0)
                {
                    moduleForm.AppCodeTextBox.Text = 1.ToString();
                }
                else
                {
                    moduleForm.AppCodeTextBox.Text = (_appsList.Last().AppCode + 1).ToString();
                }
                moduleForm.AppCodeTextBox.Enabled = false;
                moduleForm.textBox1.Text = DateTime.Now.Day.ToString();
                moduleForm.textBox2.Text = DateTime.Now.Month.ToString();
                moduleForm.textBox3.Text = DateTime.Now.Year.ToString();
                moduleForm.textBox1.Enabled = false;
                moduleForm.textBox2.Enabled = false;
                moduleForm.textBox3.Enabled = false;
                moduleForm.ShowDialog();
                LoadApps(_appsList);
            }
            catch(Exception ex)
            {
                _view.MessageFormView("Непредвиденная ошибка! " + ex.Message);
                return;
            }
        }
        public void UpdateApp(object sender, EventArgs e)
        {
            try
            {
                AppsControlModule moduleForm = new AppsControlModule(_appsList, RowToEdit);
                moduleForm.AppCodeTextBox.Enabled = false;
                moduleForm.AppCodeTextBox.Text = _appsList[RowToEdit].AppCode.ToString();
                moduleForm.AppCommTextBox.Text = _appsList[RowToEdit].AppComment.ToString();
                moduleForm.textBox1.Text = _appsList[RowToEdit].Day.ToString();
                moduleForm.textBox2.Text = _appsList[RowToEdit].Month.ToString();
                moduleForm.textBox3.Text = _appsList[RowToEdit].Year.ToString();
                moduleForm.textBox1.Enabled = false;
                moduleForm.textBox2.Enabled = false;
                moduleForm.textBox3.Enabled = false;
                moduleForm.comboBox1.Sorted = true;
                moduleForm.comboBox2.Sorted = true;
                moduleForm.ACMSaveButton.Enabled = false;
                moduleForm.ShowDialog();
                LoadApps(_appsList);
            }
            catch(Exception ex)
            {
                _view.MessageFormView("Непредвиденная ошибка! " + ex.Message);
                return;
            }
        }
        public void DeleteApp(object sender, EventArgs e)
        {
            try
            {
                _appsList.Remove(_appsList[RowToDelete]);
                JsonFileManager.SaveApps(_appsList, "data.json");
                LoadApps(_appsList);
            }
            catch (Exception ex)
            {
                _view.MessageFormView("Непредвиденная ошибка! " + ex.Message);
                return;
            }
        }
        private void OnSearch(object sender, SearchEventArgs e)
        {
            // Получаем текст запроса из аргумента события
            string searchText = e.SearchText;

            // Выполняем логику поиска по тексту запроса
            // Например, фильтруем список должностей по названию или коду
            List<Apps> filteredApps = _appsList.Where(apps => apps.AppCode.ToString().Contains(searchText) || apps.AppComment.ToString().Contains(searchText) || apps.Day.ToString().Contains(searchText) || apps.Month.ToString().Contains(searchText) || apps.Year.ToString().Contains(searchText) || apps.BlockCode.ToString().Contains(searchText)).ToList();

            // Обновляем представление с отфильтрованным списком должностей
            _view.ShowApps(filteredApps);
        }
    }
}
