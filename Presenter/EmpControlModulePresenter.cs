using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.View.Forms.ConfirmationForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;
using System.Xml.Linq;

namespace KursachFileSaving.Presenter
{
    internal class EmpControlModulePresenter
    {
        private readonly IECMView _view;
        private List<Employees> empList;
        private List<Blocks> blocksData; // Список должностей, загруженных из JSON-файла
        public int RowToEdit;
        private List<Jobs> jobsData;
        public EmpControlModulePresenter(IECMView view, List<Employees> empData, List<Blocks> blocksdata, int rowtoedit, List<Jobs> jobsList)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            empList = empData;
            blocksData = blocksdata;
            _view.SaveEmp += SaveEmp;
            _view.UpdateEmp += UpdateEmp;
            RowToEdit = rowtoedit;
            jobsData = jobsList;
            _view.SearchTextChanged += OnSearch;
            _view.MessageForm += MessageFormCreate;
        }
        private void MessageFormCreate(object sender, string message)
        {
            MessageForm mf = new MessageForm(message);
            mf.ShowDialog();
        }
        private string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] saltBytes = Convert.FromBase64String(salt);
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashedPasswordBytes = sha256.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hashedPasswordBytes);
            }
        }
        // Метод для генерации случайной соли
        private string GenerateSalt()
        {
            byte[] salt = new byte[32];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }
        private void SaveEmp(object sender, EventArgs e)
        {
            try
            {
                string salt = GenerateSalt();
                Employees emp = new Employees
                {
                    // Присваивание значений из представления
                    EmpCode = int.Parse(_view.EmpCode),
                    BlockCode = 0,
                    FirstName = _view.FirstName,
                    LastName = _view.LastName,
                    Patronymic = _view.Patronymic,
                    Login = _view.Login,
                    Salt = salt,
                    Password = HashPassword(_view.Password, salt),
                    Email = _view.Email,
                    JobCode = _view.JobCode.Split(new string[] { ". " }, StringSplitOptions.None)[1]
                };
                empList.Add(emp);

                JsonFileManager.SaveEmps(empList, "data.json");

                // Закрытие формы после сохранения
                _view.CloseForm();
            }
            catch (ArgumentException ex)
            {
                _view.MessageFormView("Ошибка! " + ex.Message);
                return;
            }
            catch (Exception ex)
            {
                _view.MessageFormView("Непредвиденная ошибка! " + ex.Message);
                return;
            }
        }
        private void UpdateEmp(object sender, EventArgs e)
        {
            try
            {
                if (_view.JobCode == "")
                {
                    _view.MessageFormView("Введите код должности!");
                    return;
                }
                if (_view.JobCode == "Системный администратор")
                {
                    Employees emp = new Employees
                    {
                        // Присваивание значений из представления
                        EmpCode = int.Parse(_view.EmpCode),
                        BlockCode = int.Parse(_view.BlockCode),
                        FirstName = _view.FirstName,
                        LastName = _view.LastName,
                        Patronymic = _view.Patronymic,
                        Login = _view.Login,
                        Salt = empList[RowToEdit].Salt,
                        Password = empList[RowToEdit].Password,
                        Email = _view.Email,
                        JobCode = _view.JobCode
                    };
                    empList.RemoveAt(RowToEdit);
                    empList.Insert(RowToEdit, emp);
                    JsonFileManager.SaveEmps(empList, "data.json");
                }
                else
                {
                    Employees emp = new Employees
                    {
                        // Присваивание значений из представления
                        EmpCode = int.Parse(_view.EmpCode),
                        BlockCode = int.Parse(_view.BlockCode),
                        FirstName = _view.FirstName,
                        LastName = _view.LastName,
                        Patronymic = _view.Patronymic,
                        Login = _view.Login,
                        Salt = empList[RowToEdit].Salt,
                        Password = empList[RowToEdit].Password,
                        Email = _view.Email,
                        JobCode = _view.JobCode.Split(new string[] { ". " }, StringSplitOptions.None)[1]
                    };
                    empList.RemoveAt(RowToEdit);
                    empList.Insert(RowToEdit, emp);
                    JsonFileManager.SaveEmps(empList, "data.json");
                }
                
                _view.CloseForm();
            }
            catch (ArgumentException ex)
            {
                _view.MessageFormView("Ошибка! " + ex.Message);
                return;
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
            List<Jobs> filteredJobs = jobsData.Where(job => job.JobCode.ToString().Contains(searchText) || job.JobName.Contains(searchText)).ToList();

            _view.ShowJobs(filteredJobs);
        }
    }
}
