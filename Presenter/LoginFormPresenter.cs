using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Newtonsoft.Json;
using System.Drawing;
using System.Windows.Forms;
using KursachFileSaving.Presenter;
using KursachFileSaving.View.Forms.JobsControlForms;
using System.IO;
using System.Security.Cryptography;

namespace KursachFileSaving.Presenter
{
    public class LoginFormPresenter
    {
        private readonly ILoginFormView _view;
        private List<Employees> _empList;
        public LoginFormPresenter(ILoginFormView view)
        {
            InitializeFile(this,EventArgs.Empty);
            _empList = JsonFileManager.LoadData().Item3;
            _view = view ?? throw new ArgumentNullException(nameof(view));

            _view.LoginAttempt += OnLoginAttempt;
        }
        public event EventHandler LoginSuccess;
        private void OnLoginAttempt(object sender, EventArgs e)
        {
            string login = _view.GetLogin();
            string password = _view.GetPassword();

            Employees user = _empList.FirstOrDefault(emp => emp.Login == login && ValidatePassword(password, emp.Salt, emp.Password));

            if (user != null)
            {
                if (user.JobCode == "Системный администратор")
                {
                    _view.LoginSuccess(this,e);
                }
                else
                {
                    _view.ShowLoginFailureMessage("Недостаточный уровень доступа");
                }
            }
            else
            {
                _view.ShowLoginFailureMessage("Неправильные логин и/или пароль");
            }
        }
        private bool ValidatePassword(string enteredPassword, string salt, string hashedPassword)
        {
            string hashedEnteredPassword = HashPassword(enteredPassword, salt);
            return hashedEnteredPassword == hashedPassword;
        }

        private void InitializeFile(object sender, EventArgs e)
        {
            if (!File.Exists("data.json"))
            {
                // Создаем пустой файл data.json
                JsonFileManager.InitializeDataIfFileNotExists();
                // Загрузка данных из файла data.json
                string salt = GenerateSalt();
                var (apps, blocks, employees, jobs, journal, po, workTypesModel) = JsonFileManager.LoadData();
                _empList = employees.ToList();
                _empList.Add(new Employees { EmpCode = 1, BlockCode = 0, FirstName = "Не указано", LastName = "Не указано", Patronymic = "Не указано", Login = "admin", Salt = salt, Password = HashPassword("admin", salt), Email = "Не указано", JobCode = "Системный администратор" });
                JsonFileManager.SaveEmps(_empList, "data.json");
                OnLoginSuccess();
            }
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
        private string GenerateSalt()
        {
            byte[] salt = new byte[32];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }
        private void OnLoginSuccess()
        {
            LoginSuccess?.Invoke(this, EventArgs.Empty);
        }
    }
}
