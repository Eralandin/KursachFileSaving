using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Classes
{
    public class Blocks
    {
        private int blockCode;
        private int ram;
        private int poCode = 0;
        private string motherboard;
        private string videocard;
        private string blockName;

        public int BlockCode
        {
            get { return blockCode; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Код блока не может быть равен нулю!");
                blockCode = value;
            }
        }

        public int RAM
        {
            get { return ram; }
            set { ram = value; }
        }

        public int POCode
        {
            get { return poCode; }
            set { poCode = value; }
        }

        public string Motherboard
        {
            get { return motherboard; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Поле 'Материнская плата' у блока не может быть равным null или быть пустым!");
                motherboard = value;
            }
        }

        public string Videocard
        {
            get { return videocard; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Поле 'Видеокарта' у блока не может быть равным null или быть пустым!");
                videocard = value;
            }
        }

        public string BlockName
        {
            get { return blockName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Название блока не может быть равным null или быть пустым!");
                blockName = value;
            }
        }
    }

}
