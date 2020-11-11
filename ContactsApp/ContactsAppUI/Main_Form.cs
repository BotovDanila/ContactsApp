using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;
namespace ContactsAppUI
{
    public partial class Main_Form : Form
    {
        public Project project;
        public string filename = @"C:\Users\Пользователь\Desktop\ContactsApp.txt";
        public Main_Form()
        {
            InitializeComponent();
            project = new Project();

            PhoneNumber phone = new PhoneNumber();
            phone.Number = 79234426052;

            Contact contact = new Contact();
            contact.Name = "Sergei";
            contact.Surname = "iVanov";
            contact.Number = phone;
            contact.VKId = "13er456";
            contact.BirthDate = new DateTime(2005, 2, 4);
            contact.Email = "ssse@mail.ru";

            textBox1.Text = contact.Surname;
            textBox2.Text = contact.Name;

            project._contactList.Add(contact);
            ProjectManager.SaveToFile(project, filename);
            project = null;
           project= ProjectManager.LoadFromFile(filename);
        }
    }
    
}
