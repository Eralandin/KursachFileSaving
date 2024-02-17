using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Classes
{
    public class WorkTypesModel
    {
        public List<WorkType> WTs;  
        public WorkTypesModel()
        {
            WTs = new List<WorkType>();
        }
        public void Change(int ID, string worktypename, string worktypecomm)
        {
            WTs[ID].WorkTypeName = worktypename;
            WTs[ID].WorkTypeComm = worktypecomm;
        }
        public string Message
        {
            get { return "Тип работы изменён!"; }
        }
    }
    public class WorkType
    {
        private int worktypecode;
        private string worktypename;
        private string worktypecomm;
        public WorkType(int Worktypecode, string Worktypename, string Worktypecomm)
        {
            this.worktypecode = Worktypecode;
            this.worktypename = Worktypename;
            this.worktypecomm = Worktypecomm;
        }
        public int WorkTypeCode { get { return this.worktypecode; } set { this.worktypecode = value; } }
        public string WorkTypeName { get { return this.worktypename; } set { this.worktypename = value; } }
        public string WorkTypeComm { get { return this.worktypecomm; } set { this.worktypecomm = value; } }

    }
}
