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
    public class Contact : IComparable<Contact> 
    {
        private string _surname;
        private string _name;
        private PhoneNumber _number;
        private DateTime _birthDate;
        private string _vkId;
        private string _email;

        /// <summary>
        /// Фамилия не может быть больше 50 символов
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
                _surname = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        /// <summary>
        /// Имя не может быть больше 50 символов
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if(value.Length>50)
                {
                    throw new ArgumentException("Имя должно содержать меньше 50 символов");
                }
                _name = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower(); ;
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

        /// <summary>
        /// ВКайди контакта, ограничение в 15 символов
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("максимальное количество символов = 50!");
                }
                              
                _email = value;                
            }
        }
        public override string ToString()
        {
            var name = Name;
            var surname = Surname;
            return name + " " + surname;
        }

        public int CompareTo(Contact comparedObj)
        {
            return this.Surname.CompareTo(comparedObj.Surname);
        }
    }
}
