using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Classes
{
    internal class Employees
    {
        public int EmpCode {  get; set; }
        public int BlockCode { get; set; } = 0;
        public int AppCode { get; set; } = 0;
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; } = "Не указано";
        public string Login {  get; set; }
        private string Password { get; set; }
        public string Email { get; set; }
        public int JobCode {  get; set; }
        public int WorkCode {  get; set; }
        private string Salt { get; set; }
    }
}
