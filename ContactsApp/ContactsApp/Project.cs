using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс, содержащий список всех контактов
    /// </summary>
  public  class Project
    {
      public List<Contact> _contactList;

        public Project()
        {
            _contactList = new List<Contact>(200);
        }
        /// <summary>
        /// Поиск контактов содержащих в своем имени или фамилии конкретной строчки
        /// </summary>
        /// <param name="lookforstring"></param>
        /// <returns></returns>
        public List<Contact> FindName(string lookforstring)
        {
            List<Contact> searchlist = new List<Contact>();
            searchlist.AddRange(_contactList.FindAll(x => x.Surname.Contains(lookforstring) || x.Name.Contains(lookforstring)));
            return searchlist;

        }

        /// <summary>
        /// поиск именинников из текущего списка контактов и создание списка из таких контактов
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<Contact> BirthdayMan(DateTime date)
        {
            var birthdatemanList = new List<Contact>();
            var Contactlist = new List<Contact>();
            Contactlist = _contactList;
            foreach (Contact contact in Contactlist)
            {
                if (contact.BirthDate.Month == date.Month && contact.BirthDate.Day == date.Day)
                {
                    birthdatemanList.Add((contact));
                }
            }
            return birthdatemanList;
        }
    }
}
