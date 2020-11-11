using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class PhoneNumber
    {
        private long _number;
        /// <summary>
        /// Класс,описывающий номер телефона
        /// </summary>
        public long Number
        {
            get { return _number; }
            set
            {
                if(value<0 || value!=11)
                {
                    throw new ArgumentException("Номер телефона должен содержать 11 цифр");
                }
                else if(value/10000000000!=7)
                {
                    throw new ArgumentException("Номер телефона должен начинаться на +7");
                }
                _number = value;
            }
        }
    }
}
