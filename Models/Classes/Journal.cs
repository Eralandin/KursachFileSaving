using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Classes
{
    public class Journal
    {
        private int recordCode;
        private int blockCode;
        private int appCode;
        private string workCode;
        private string date;
        private string dateEnd;
        private string commentary;

        public int RecordCode
        {
            get { return recordCode; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Код записи не может быть равен нулю!");
                recordCode = value;
            }
        }
        public string DateEnd
        {
            get { return dateEnd; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Дата окончания не может быть пустой!");
                dateEnd = value;
            }
        }

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

        public int AppCode
        {
            get { return appCode; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Код заявки не может быть равен нулю!");
                appCode = value;
            }
        }

        public string WorkCode
        {
            get { return workCode; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Тип работы не может быть пустым!");
                workCode = value;
            }
        }

        public string Date
        {
            get { return date; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Дата начала не может быть пустой!");
                date = value;
            }
        }

        public string Commentary
        {
            get { return commentary; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Комментарий не может быть пустым!");
                commentary = value;
            }
        }
    }
}
