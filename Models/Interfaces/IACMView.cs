using KursachFileSaving.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Models.Interfaces
{
    public interface IACMView
    {
        string AppCode { get; set; }
        string BlockCode { get; set; }
        string Day { get; set; }
        string Month { get; set; }
        string Year { get; set; }
        string AppComment { get; set; }
        string WorkType { get; set; }

        event EventHandler SaveApp;
        event EventHandler UpdateApp;
        event EventHandler Cancel;
        event EventHandler<string> MessageForm;
        void MessageFormView(string message);
        void CloseForm();
    }
}
