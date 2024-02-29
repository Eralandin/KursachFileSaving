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
        public string EncryptPassword(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Конкатенируем пароль и соль
                string saltedPassword = password + salt;

                // Преобразуем комбинацию пароля и соли в массив байтов
                byte[] bytes = Encoding.UTF8.GetBytes(saltedPassword);

                // Вычисляем хэш
                byte[] hash = sha256.ComputeHash(bytes);

                // Преобразуем хэш в строку Hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("x2"));
                }

                // Возвращаем зашифрованный пароль
                return builder.ToString();
            }
        }
        // Метод для генерации случайной соли
        public string GenerateSalt(int size)
        {
            // Создаем объект RNGCryptoServiceProvider для генерации случайных байтов
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] saltBytes = new byte[size];

                // Заполняем массив байтов случайными значениями
                rng.GetBytes(saltBytes);

                // Преобразуем байты в строку Hexadecimal
                string salt = BitConverter.ToString(saltBytes).Replace("-", "");

                return salt;
            }
        }
        private void SaveEmp(object sender, EventArgs e)
        {
            try
            {
                string salt = GenerateSalt(16);
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
                    Password = EncryptPassword(_view.Password, salt),
                    Email = _view.Email,
                    JobCode = int.Parse(_view.JobCode),
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
                string salt = GenerateSalt(16);
                if (_view.JobCode == "")
                {
                    _view.MessageFormView("Введите код должности!");
                    return;
                }
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
                    JobCode = int.Parse(_view.JobCode),
                };
                empList.RemoveAt(RowToEdit);
                empList.Insert(RowToEdit, emp);
                JsonFileManager.SaveEmps(empList, "data.json");
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
