using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Interfaces
{
    public interface IPOModuleView
    {
        string POCode { get; set; }
        string POName { get; set; }
        string BlockCode {  get; set; }

        event EventHandler SavePO;
        event EventHandler UpdatePO;
        event EventHandler Cancel;
        event EventHandler<string> MessageForm;
        void MessageFormView(string message);
        void CloseForm();
    }
}
