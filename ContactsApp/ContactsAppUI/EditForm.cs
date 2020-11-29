using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class EditForm : Form
    {
        public Contact current;
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
           if(current!=null)
            {
                NameTextBox.Text = current.Name;
                SurnameTextBox.Text = current.Surname;
                PhoneMaskedTextBox.Text = current.Number.Number.ToString();
                EmailTextBox.Text = current.Email;
                BirthDateDateTimePicker.Text = current.BirthDate.ToString();
                VkIdTextBox.Text = current.VKId;
            }
            else
            {
                current = new Contact();
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                current.Number = new PhoneNumber();
                current.Name = NameTextBox.Text;
                current.Surname = SurnameTextBox.Text;
                current.Email = EmailTextBox.Text;
                current.VKId = VkIdTextBox.Text;
                current.BirthDate = BirthDateDateTimePicker.Value;
                current.Number.Number = Convert.ToInt64(PhoneMaskedTextBox.Text);
                DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void BanSpecialSymbols(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex(@"[^a-zA-Z0-9\b\s]");
            if ((reg.IsMatch(e.KeyChar.ToString())))
            {
                e.Handled = true;
                this.BackColor = Color.Red;
            }
            else
                this.BackColor = Color.White;
        }
    }
}
