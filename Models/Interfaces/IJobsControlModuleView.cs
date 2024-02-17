using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Interfaces
{
    public interface IJobsControlModuleView
    {
        string JobCode { get; set; }
        string JobName { get; set; }

        event EventHandler SaveJob;
        event EventHandler UpdateJob;
        event EventHandler Cancel;
        void CloseForm();
    }
}
