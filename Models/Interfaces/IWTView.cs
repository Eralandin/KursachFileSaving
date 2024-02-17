using KursachFileSaving.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Models.Interfaces
{
    public interface IWTView
    {
        event EventHandler Load;
        event EventHandler AddWT;
        event EventHandler UpdateWT;
        event EventHandler DeleteWT;
        event EventHandler<SearchEventArgs> SearchTextChanged;
        string SearchText { get; }

        void ShowWTs(List<WorkType> wts);
        void ShowMessage(string message);
    }
}
