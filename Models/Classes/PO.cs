using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Classes
{
    public class PO
    {
        public int POCode {  get; set; }
        public int BlockCode { get; set; } = 0;
        public string POName { get; set; }
    }
}
