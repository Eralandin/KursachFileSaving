using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Classes
{
    public class Journal
    {
        public int RecordCode { get; set; }
        public int BlockCode { get; set; }
        public int AppCode {  get; set; }
        public int WorkCode {  get; set; }
        public string Date {  get; set; }
        public string Commentary { get; set; }
    }
}
