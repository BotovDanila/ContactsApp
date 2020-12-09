using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    class ProjectManagerTest
    {
        private Project actualProject = new Project();
        private Project expectedProject = new Project();


        [Test(Description = "Тест метода SaveToFile")]
        public void TestSaveToFile_CorrectValue()
        {
            var _path = @"C:\Users\Пользователь\Desktop\ContactsApp.txt";
            

            Contact expectedContact = new Contact();
           
            PhoneNumber actualPhone = new PhoneNumber();
            actualPhone.Number = 79998887766;

            Contact actualContact = new Contact();
            actualContact.Name = "petya";
            actualContact.Surname = "pEtRoVS";
            actualContact.Number = actualPhone;
            actualContact.VKId = "12456";
            actualContact.BirthDate = new DateTime(2000, 12, 3);
            actualContact.Email = "mail@mail.ru";


            actualProject._contactList.Add(actualContact);
            ProjectManager.SaveToFile(actualProject, _path);
            expectedProject = null;
            expectedProject = ProjectManager.LoadFromFile(_path);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedProject._contactList[0].Name, actualProject._contactList[0].Name, "Метод SaveToFile неправильно сохраняет проект(имя)");
                Assert.AreEqual(expectedProject._contactList[0].Surname, actualProject._contactList[0].Surname, "Метод SaveToFile неправильно сохраняет проект(фамилия)");
                Assert.AreEqual(expectedProject._contactList[0].VKId, actualProject._contactList[0].VKId, "Метод SaveToFile неправильно сохраняет проект(айди-вк)");
                Assert.AreEqual(expectedProject._contactList[0].Email, actualProject._contactList[0].Email, "Метод SaveToFile неправильно сохраняет проект(почта)");
                Assert.AreEqual(expectedProject._contactList[0].BirthDate, actualProject._contactList[0].BirthDate, "Метод SaveToFile неправильно сохраняет проект(дата рождения)");
                Assert.AreEqual(expectedProject._contactList[0].Number.Number, actualProject._contactList[0].Number.Number, "Метод SaveToFile неправильно сохраняет проект(номер телефогна)");
            });

        }

    }
}

