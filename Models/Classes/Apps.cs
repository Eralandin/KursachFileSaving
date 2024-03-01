using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Classes
{
    public class Apps
    {
        private int appCode;
        private string appComment;
        private int day;
        private int month;
        private int year;
        private int blockCode;
        private string workType;

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

        public string AppComment
        {
            get { return appComment; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Комментарий к заявке необходимо заполнить!");
                appComment = value;
            }
        }

        public int Day
        {
            get { return day; }
            set
            {
                if (value < 1 || value > 31)
                    throw new ArgumentException("День должен быть в диапазоне от 1 до 31!");
                day = value;
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException("Месяц должен быть в диапазоне от 1 до 12!");
                month = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1900 || value > 2100)
                    throw new ArgumentException("Год должен быть в диапазоне от 1900 до 2100!");
                year = value;
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
        public string WorkType
        {
            get { return workType; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Тип работы необходимо заполнить!");
                workType = value;
            }
        }
    }
}
