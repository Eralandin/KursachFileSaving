using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Interfaces
{
    public interface IWTMView
    {
        string WorkTypeCode { get; set; }
        string WorkTypeName { get; set; }
        string WorkTypeComm { get; set; }

        event EventHandler SaveWT;
        event EventHandler UpdateWT;
        event EventHandler Cancel;
        event EventHandler<string> MessageForm;
        void MessageFormView(string message);
        void CloseForm();
    }
}
