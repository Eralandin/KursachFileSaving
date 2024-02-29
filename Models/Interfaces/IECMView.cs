using KursachFileSaving.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Models.Interfaces
{
    internal interface IECMView
    {

        event EventHandler SaveEmp;
        event EventHandler UpdateEmp;
        event EventHandler Cancel;
        event EventHandler<SearchEventArgs> SearchTextChanged;
        event EventHandler<string> MessageForm;
        string SearchText { get; }
        void ShowEmps(List<Employees> empsList);
        void MessageFormView(string message);
        void CloseForm();
    }
}
