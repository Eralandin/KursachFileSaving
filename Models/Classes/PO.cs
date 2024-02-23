using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Classes
{
    public class PO
    {
        private int poCode;
        private int blockCode = 0;
        private string poName;

        public int POCode
        {
            get { return poCode; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Код ПО не может быть равным нулю!");
                poCode = value;
            }
        }

        public int BlockCode
        {
            get { return blockCode; }
            set { blockCode = value; }
        }

        public string POName
        {
            get { return poName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Название ПО не может быть равным null или пустым!");
                poName = value;
            }
        }
    }
}
