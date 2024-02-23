using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Classes
{
    public class Jobs
    {
        public int jobCode;
        public string jobName;
        public int JobCode
        {
            get { return jobCode; }
            set
            {
                if (value != 0)
                    jobCode = value;
                else
                    throw new ArgumentException("Код должности не может быть равным нулю!");
            }
        }

        public string JobName
        {
            get { return jobName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Название должности не может быть равным null или быть пустым!");
                jobName = value;
            }
        }
    }
}
