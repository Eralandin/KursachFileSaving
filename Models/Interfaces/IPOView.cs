using KursachFileSaving.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Models.Interfaces
{
    public interface IPOView
    {
        event EventHandler Load;
        event EventHandler AddPO;
        event EventHandler UpdatePO;
        event EventHandler DeletePO;
        event EventHandler<SearchEventArgs> SearchTextChanged;
        event EventHandler<string> MessageForm;

        string SearchText { get; }

        void ShowPOs(List<PO> poList);
    }
}
