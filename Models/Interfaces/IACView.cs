using KursachFileSaving.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Models.Interfaces
{
    public interface IACView
    {
        event EventHandler Load;
        event EventHandler AddApp;
        event EventHandler UpdateApp;
        event EventHandler DeleteApp;
        event EventHandler<SearchEventArgs> SearchTextChanged;
        event EventHandler<string> MessageForm;

        string SearchText { get; }
        void MessageFormView(string message);
        void ShowApps(List<Apps> appsList);
    }
}
