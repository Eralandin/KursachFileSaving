using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Classes
{
    public class WorkType
    {
        public int workTypeCode;
        public string workTypeName;
        public string workTypeComm;
        public int WorkTypeCode
        {
            get { return workTypeCode; }
            set
            {
                if (value != 0)
                    workTypeCode = value;
                else
                    throw new ArgumentException("Код типа работы не может быть равным нулю!");
            }
        }
        public string WorkTypeName
        {
            get { return workTypeName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Название типа работы не может быть пустым!");
                workTypeName = value;
            }
        }
        public string WorkTypeComm
        {
            get { return workTypeComm; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Комментарий к типу работы не может быть пустым!");
                workTypeComm = value;
            }
        }
    }
}
