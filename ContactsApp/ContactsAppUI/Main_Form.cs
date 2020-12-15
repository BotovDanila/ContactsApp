﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private BindingList<Contact> formlist;
        public string filename = "ContactsApp.txt";
        public string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Main_Form()
        {
            InitializeComponent();
            project = new Project();

            /*  PhoneNumber phone = new PhoneNumber();
              phone.Number = 79234426052;

              Contact contact = new Contact();
              contact.Name = "Sergei";
              contact.Surname = "iVanov";
              contact.Number = phone;
              contact.VKId = "13er456";
              contact.BirthDate = new DateTime(2005, 2, 4);
              contact.Email = "ssse@mail.ru";
              PhoneNumber phone1 = new PhoneNumber();
              phone1.Number = 78524785969;

              Contact contact1 = new Contact();
              contact1.Name = "Petya";
              contact1.Surname = "simonov";
              contact1.Number = phone1;
              contact1.VKId = "1233256";
              contact1.BirthDate = new DateTime(2000, 3, 1);
              contact1.Email = "ssaaeqewe@mail.ru"; 
              PhoneNumber phone2 = new PhoneNumber();
              phone2.Number = 78734917392;

              Contact contact2 = new Contact();
              contact2.Name = "ivan";
              contact2.Surname = "popov";
              contact2.Number = phone2;
              contact2.VKId = "65431234";
              contact2.BirthDate = new DateTime(1998, 10, 21);
              contact2.Email = "ceqeiuj@mail.ru"; 
              PhoneNumber phone3 = new PhoneNumber();
              phone3.Number = 79384774712;

              Contact contact3 = new Contact();
              contact3.Name = "anna";
              contact3.Surname = "perkova";
              contact3.Number = phone3;
              contact3.VKId = "ihviuw7f4y";
              contact3.BirthDate = new DateTime(1993, 4, 15);
              contact3.Email = "diyfewg@mail.ru";



              project._contactList.Add(contact);
              project._contactList.Add(contact1);
              project._contactList.Add(contact2);
              project._contactList.Add(contact3);
              ProjectManager.SaveToFile(project, filename);
              project = null;
             project= ProjectManager.LoadFromFile(filename);*/
        }

        private void RefreshContactInfo()
        {
            if (formlist.Count != 0)
            {
                var index = ContactsListBox.SelectedIndex;
                Contact selectedContact = index == -1 ? formlist.Last() : formlist[index];
                NameTextBox.Text = selectedContact.Name;
                SurnameTextBox.Text = selectedContact.Surname;
                BirthDateDateTimePicker.Text = selectedContact.BirthDate.ToString();
                EmailTextBox.Text = selectedContact.Email;
                VkIdTextBox.Text = selectedContact.VKId;
                PhoneMaskedTextBox1.Text = selectedContact.Number.Number.ToString();
            }
            else
            {
                ClearContactInfo();
            }
        }
        private void ClearContactInfo()
        {
            NameTextBox.Text = "";
            SurnameTextBox.Text = "";
            BirthDateDateTimePicker.Text = "";
            PhoneMaskedTextBox1.Text = "";
            EmailTextBox.Text = "";
            VkIdTextBox.Text = "";
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            if (File.Exists(filepath + @"\" + filename))
            {
                project = ProjectManager.LoadFromFile(filepath + @"\" + filename);
                formlist = new BindingList<Contact>(project._contactList);
            }
            else
            {
                project = new Project();
                formlist = new BindingList<Contact>();
            }
            ContactsListBox.DataSource = formlist;
            CheckBirthday();
        }


        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FindTableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.current = formlist[ContactsListBox.SelectedIndex];
            DialogResult result = editForm.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                editForm.Close();
            }
            else if (result == DialogResult.OK)
            {
                formlist[ContactsListBox.SelectedIndex] = editForm.current;
                editForm.Close();
            }
            SortContactsListBox();
            RefreshContactInfo();

        }

        private void ContactsListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshContactInfo();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            DialogResult result = editForm.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                editForm.Close();
            }
            else if (result == DialogResult.OK)
            {
                formlist.Add(editForm.current);
                editForm.Close();
                SortContactsListBox();
                RefreshContactInfo();
            }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить данный контакт?", "Удалить контакт", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                formlist.Remove((Contact)ContactsListBox.SelectedItem);
                SortContactsListBox();
                RefreshContactInfo();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "txt files(*.txt)| *.txt | All files(*.*) | *.* ";
            fileDialog.FileName = "ContactsApp";
            project._contactList = formlist.ToList();
            if (fileDialog.ShowDialog() == DialogResult.OK)
                ProjectManager.SaveToFile(project, (filepath + @"\" + filename));
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "contacts(*.txt)| *.txt | All files(*.*) | *.* ";
            fileDialog.FileName = "ContactsApp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                formlist = new BindingList<Contact>(ProjectManager.LoadFromFile(fileDialog.FileName)._contactList);
                ContactsListBox.DataSource = formlist;
            }
        }

        private void SortContactsListBox()
        {
            var contactList = formlist.ToList();
            contactList.Sort();
            formlist = new BindingList<Contact>(contactList);
            //_formlist.ToList().Sort();
            ContactsListBox.DataSource = formlist;
        }

        private void CheckBirthday()
        {
            var birthdayMen = project.BirthdayMan(DateTime.Today);
            var labelText = "";
            if (birthdayMen.Count != 0)
            {
                labelText = @"Сегодня день рождения отмечает:  " + "\r\n";
                foreach (var birthdayBoy in birthdayMen)
                {
                    labelText += $@"{birthdayBoy.Name} {birthdayBoy.Surname} " + "\r\n";
                }
            }
            else
            {
                labelText = @"Сегодня именинников нет.";
            }

            BirthdayLabel.Text = labelText;
        }

        private void FindTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (FindTextBox.Text != string.Empty)
                {
                    var findString = FindTextBox.Text;
                    project._contactList = formlist.ToList();
                    var searchlist = project.FindName(findString);
                    formlist = new BindingList<Contact>(searchlist);
                    SortContactsListBox();
                }
                else
                {
                    formlist = new BindingList<Contact>(project._contactList);
                    SortContactsListBox();
                }
            }
        }

        private void ContactsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveButton_Click(null, null);
            }
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveToFile(project, (filepath + @"\" + filename));
        }
    }
}
