using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Classes
{
    public class Blocks
    {
        public int BlockCode {  get; set; }
        public string Motherboard { get; set; }
        public int RAM { get; set; }
        public string Videocard {  get; set; }
        public string BlockName { get; set; }
        public int POCOde {  get; set; } = 0;
    }
}
