using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Classes
{
    public class Employees
    {
        private int empCode;
        private int blockCode = 0;
        private string firstName;
        private string lastName;
        private string patronymic = "Не указано";
        private string login;
        private string password;
        private string email;
        private string jobCode;
        private string salt;

        public int EmpCode
        {
            get { return empCode; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Код сотрудника не может быть равен нулю!");
                empCode = value;
            }
        }

        public int BlockCode
        {
            get { return blockCode; }
            set { blockCode = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Имя сотрудника не может быть равным null или быть пустым!");
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Фамилия сотрудника не может быть равной null или быть пустой!");
                lastName = value;
            }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }

        public string Login
        {
            get { return login; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Логин сотрудника не может быть равен null или быть пустым!");
                login = value;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Пароль сотрудника не может быть равен null или быть пустым!");
                password = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Email сотрудника не может быть равен null или быть пустым!");
                email = value;
            }
        }

        public string JobCode
        {
            get { return jobCode; }
            set 
            {   if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Должность должна быть присвоена каждому сотруднику!");
                jobCode = value; 
            }
        }

        public string Salt
        {
            get { return salt; }
            set { salt = value; }
        }
    }
}

