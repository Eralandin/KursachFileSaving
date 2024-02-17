using KursachFileSaving.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Models.Interfaces
{
    public interface IJobsControlView
    {
        event EventHandler Load;
        event EventHandler AddJob;
        event EventHandler UpdateJob;
        event EventHandler DeleteJob;
        event EventHandler<SearchEventArgs> SearchTextChanged;
        string SearchText { get; }

        void ShowJobs(List<Jobs> jobs);
        void ShowMessage(string message);
    }
}
