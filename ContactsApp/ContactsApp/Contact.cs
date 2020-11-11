using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс,описывающий контакт
    /// </summary>
    public class Contact
    {
        private string _surname;
        private string _name;
        private PhoneNumber _number;
        private DateTime _birthDate;
        private string _vkId;
        
        /// <summary>
        /// Фамилия не може быть больше 50 символов
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                if(value.Length>50)
                {
                    throw new ArgumentException("Фамилия должна содержать меньше 50 символов");
                }
                _surname = value.Substring(0, 1).ToUpper() + value.Substring(2).ToLower();
            }
        }

        /// <summary>
        /// Имя не може быть больше 50 символов
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if(value.Length>50)
                {
                    throw new ArgumentException("Имя должна содержать меньше 50 символов");
                }
                _name = value.Substring(0, 1).ToUpper() + value.Substring(2).ToLower(); ;
            }
        }

        /// <summary>
        /// Номер телефона контакта
        /// </summary>
        public PhoneNumber Number
        {
            get { return _number; }
            set
            {
                _number = value;
            }
        }

        /// <summary>
        /// ID ВК не может быть больше 15 символов
        /// </summary>
        public string VKId
        {
            get { return _vkId; }
            set
            {
                if(value.Length>15)
                {
                    throw new ArgumentException("ID должен быть меньше 15 символов");
                }
                _vkId = value;
            }
        }

        /// <summary>
        /// Дата рождения не может быть более текущей даты и не может быть менее 1900 года
        /// </summary>
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if(value.Year<1900||value>DateTime.Now)
                {
                    throw new ArgumentException("Дата рождения не может быть более текущей даты и не может быть менее 1900 года");
                }
                _birthDate = value;
            }
        }
    }
}
