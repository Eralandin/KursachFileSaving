using KursachFileSaving.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Presenter
{
    internal class WTPresenter
    {
        private WorkTypesModel WTs;
        private WorkType WT;
        public WTPresenter(WorkTypesModel wts)
        {
            this.WTs = wts;
        }
        public WorkTypesModel Change(int ID,string worktypename,string worktypecomm)
        {
            this.WTs.Change(ID,worktypename,worktypecomm);
            return this.WTs;
        }
    }
}
