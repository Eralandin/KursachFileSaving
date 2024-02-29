using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.View.Forms.BlocksControlForms;
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
    internal class EmpControlPresenter
    {
        private readonly IECView _view;
        private List<Employees> _empsList;

        public int RowToDelete;
        public int RowToEdit;

        public EmpControlPresenter(IECView view, List<Employees> empsList)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _empsList = empsList;

            _view.Load += OnLoad;
            _view.AddEmp += AddEmp;
            _view.UpdateEmp += UpdateEmp;
            _view.DeleteEmp += DeleteEmp;
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
            LoadEmps(_empsList);
        }

        private void LoadEmps(List<Employees> empsList)
        {
            _view.ShowEmps(empsList);
        }

        public void AddEmp(object sender, EventArgs e)
        {
            EmpControlModule moduleForm = new EmpControlModule(_empsList, RowToEdit);
            moduleForm.ECMUpdateButton.Enabled = false;
            moduleForm.DGVECMJobs.Enabled = false;
            moduleForm.DGVECMJobsSearchTextBox.Enabled = false;
            moduleForm.label12.Enabled = false;
            if (_empsList.Count == 0)
            {
                moduleForm.EmpCodeTextBox.Text = 1.ToString();
            }
            else
            {
                moduleForm.EmpCodeTextBox.Text = (_empsList.Last().EmpCode + 1).ToString();
            }
            moduleForm.comboBox1.Enabled = false;
            moduleForm.EmpCodeTextBox.Enabled = false;
            moduleForm.ShowDialog();
            LoadEmps(_empsList);
        }
        public void UpdateEmp(object sender, EventArgs e)
        {
            EmpControlModule moduleForm = new EmpControlModule(_empsList, RowToEdit);
            moduleForm.EmpCodeTextBox.Enabled = false;
            moduleForm.EmpCodeTextBox.Text = _empsList[RowToEdit].EmpCode.ToString();
            moduleForm.EmpLastnameTextBox.Text = _empsList[RowToEdit].LastName.ToString();
            moduleForm.EmpNameTextBox.Text = _empsList[RowToEdit].FirstName.ToString();
            moduleForm.EmpPatronymicTextBox.Text = _empsList[RowToEdit].Patronymic.ToString();
            moduleForm.EmpEmailTextBox.Text = _empsList[RowToEdit].Email.ToString();
            moduleForm.EmpLoginTextBox.Text = _empsList[RowToEdit].Login.ToString();
            moduleForm.EmpPasswordTextBox.Enabled = false;

            if (_empsList[RowToEdit].JobCode != 0)
            {
                moduleForm.JobCodeCombobox.Items.Add(_empsList[RowToEdit].JobCode.ToString());
            }
            if (_empsList[RowToEdit].BlockCode != 0)
            {
                moduleForm.comboBox1.Items.Add(_empsList[RowToEdit].BlockCode.ToString());
            }
            moduleForm.JobCodeCombobox.Sorted = true;
            moduleForm.comboBox1.Sorted = true;
            moduleForm.ECMSaveButton.Enabled = false;
            moduleForm.ShowDialog();
            LoadEmps(_empsList);
        }

        public void DeleteEmp(object sender, EventArgs e)
        {
            try
            {
                _empsList.Remove(_empsList[RowToDelete]);
                JsonFileManager.SaveEmps(_empsList, "data.json");
                LoadEmps(_empsList);
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
            List<Employees> filteredEmps = _empsList.Where(emps => emps.EmpCode.ToString().Contains(searchText) || emps.LastName.ToString().Contains(searchText) || emps.FirstName.ToString().Contains(searchText) || emps.Patronymic.ToString().Contains(searchText) || emps.Login.ToString().Contains(searchText) || emps.Email.ToString().Contains(searchText) || emps.BlockCode.ToString().Contains(searchText) || emps.JobCode.ToString().Contains(searchText)).ToList();

            // Обновляем представление с отфильтрованным списком должностей
            _view.ShowEmps(filteredEmps);
        }
    }
}
