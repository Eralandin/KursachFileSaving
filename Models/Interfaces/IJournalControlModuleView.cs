using KursachFileSaving.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Interfaces
{
    internal interface IJournalControlModuleView
    {
        string RecordCode { get; set; }
        string AppCode { get; set; }
        string BlockCode { get; set; }
        string Date {  get; set; }
        string DateOfEnd {  get; set; }
        string Commentary { get; set; }
        string WorkCode { get; set; }

        event EventHandler SaveJournal;
        event EventHandler<int> CheckApp;
        event EventHandler Cancel;
        event EventHandler<string> MessageForm;
        void MessageFormView(string message);
        void CloseForm();
    }
}
