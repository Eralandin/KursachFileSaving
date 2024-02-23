using KursachFileSaving.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Models.Interfaces
{
    public interface IBCMView
    {
        string BlockCode { get; set; }
        string BlockName { get; set; }
        string Motherboard { get; set; }
        string Videocard { get; set; }
        string RAM { get; set; }
        string POCOde { get; set; }

        event EventHandler SaveBlock;
        event EventHandler UpdateBlock;
        event EventHandler Cancel;
        event EventHandler<SearchEventArgs> SearchTextChanged;
        string SearchText { get; }
        void ShowPOs(List<PO> poList);
        void CloseForm();
    }
}
