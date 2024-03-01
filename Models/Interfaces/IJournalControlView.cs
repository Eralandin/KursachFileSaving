using KursachFileSaving.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Models.Interfaces
{
    internal interface IJournalControlView
    {
        event EventHandler Load;
        event EventHandler AddJournal;
        event EventHandler DeleteJournal;
        event EventHandler<SearchEventArgs> SearchTextChanged;
        event EventHandler<string> MessageForm;

        string SearchText { get; }
        void MessageFormView(string message);
        void ShowJournal(List<Journal> journalList);
    }
}
