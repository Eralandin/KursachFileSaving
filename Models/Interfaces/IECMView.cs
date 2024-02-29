using KursachFileSaving.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Models.Interfaces
{
    public interface IECMView
    {
        string EmpCode { get; set; }
        string BlockCode { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Patronymic { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        string JobCode { get; set; }

        event EventHandler SaveEmp;
        event EventHandler UpdateEmp;
        event EventHandler Cancel;
        event EventHandler<SearchEventArgs> SearchTextChanged;
        event EventHandler<string> MessageForm;
        string SearchText { get; }
        void ShowJobs(List<Jobs> jobsList);
        void MessageFormView(string message);
        void CloseForm();
    }
}
