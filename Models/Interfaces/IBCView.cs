using KursachFileSaving.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Models.Interfaces
{
    public interface IBCView
    {
        event EventHandler Load;
        event EventHandler AddBlock;
        event EventHandler UpdateBlock;
        event EventHandler DeleteBlock;
        event EventHandler<SearchEventArgs> SearchTextChanged;

        string SearchText { get; }

        void ShowBlocks(List<Blocks> blocksList);
    }
}
