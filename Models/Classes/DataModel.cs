using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Classes
{
    public class DataModel
    {
        public List<Apps> Apps { get; set; }
        public List<Blocks> Blocks { get; set; }
        public List<Employees> Employees { get; set; }
        public List<Jobs> Jobs { get; set; }
        public List<Journal> Journal { get; set; }
        public List<PO> PO { get; set; }
        public WorkTypesModel WorkTypesModel { get; set; }
    }
}
