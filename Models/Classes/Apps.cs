using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Classes
{
    public class Apps
    {
        public int AppCode {  get; set; }
        public string AppComment { get; set; }
        public int Day {  get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int EmpCode { get; set; }
    }
}
