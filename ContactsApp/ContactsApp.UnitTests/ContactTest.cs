using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ContactTest
    {
        private Contact _contact;

        [SetUp]
        public void Setup()
        {
            _contact = new Contact();
        }

        [Test(Description = "Тест геттера Surname")]
        public void TestSurnameGet_CorrectValue()
        {
            var expected = "Смирнов";
            _contact.Surname = expected;
            var actual = _contact.Surname;
            Assert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию");
        }

        [Test(Description = "Позитивный тест сеттера Surname")]
        public void TestSurnameSet_CorrectValue()
        {
            var expected = "Смирнов";
            _contact.Surname = expected;
            var actual = "Смирнов";
            Assert.AreEqual(expected, actual, "Сеттер Surname записывает неправильную фамилию");
        }

        [Test(Description = "Негативный тест сеттера Surname")]
        public void TestSurnameSet_IncorrectValue()
        {
            var wrongSurname = "ЧСМИТКПРОЛДЖАПРОЛДАПРОЛДАПРОЛВАПРОЛДЖДЛОРПВВАПРОЛДЩШГНЕКУЦЫВАПРОЛДЗЩШГНЕКУЦ";
            Assert.Throws<ArgumentException>(() => { _contact.Surname = wrongSurname; },
                "Должно возникать исключение, если длина фамилии больше 50 символов");
        }

        ////////////////////////////////////////        

        [Test(Description = "Тест геттера Name")]
        public void TestName_CorrectValue()
        {
            var expected = "Петя";
            _contact.Name = expected;
            var actual = _contact.Name;
            Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильное имя");
        }

        [Test(Description = "Позитивный тест сеттера Name")]
        public void TestNameSet_CorrectValue()
        {
            var expected = "Петя";
            _contact.Name = expected;
            var actual = "Петя";
            Assert.AreEqual(expected, actual, "Сеттер Name записывает неправильное имя");
        }

        [Test(Description = "Негативный тест сеттера Name")]
        public void TestNameSet_IncorrectValue()
        {
            var wrongName = "ЫВАПРОЛДлорпавапролдлорпавывапролорпыыукенгшгнекукенгшщшгнеквапролрпсмитрпаапрлшгнекенгшгнеапролорпапролорпанггнекенгшгн";
            Assert.Throws<ArgumentException>(() => { _contact.Name = wrongName; },
                "Должное возникать исключение, если имя длиннее 50 символов");
        }

        ////////////////////////////////////////

        [Test(Description = "Тест геттера PhoneNumber")]
        public void TestPhoneNumberGet_CorrectValue()
        {
            var expected = new PhoneNumber();
            expected.Number = 79098888355;
            _contact.Number = expected;
            var actual = _contact.Number;
            Assert.AreEqual(expected, actual, "Геттер PhoneNumber возвращает неправильный номер телефона");
        }

        [Test(Description = "Позитивный тест сеттера PhoneNumber")]
        public void TestPhoneNumberSet_CorrectValue()
        {
            var expected = new PhoneNumber();
            var actual = new PhoneNumber();
            expected.Number = 79098888355;
            _contact.Number = expected;
            actual = _contact.Number;
            Assert.AreEqual(expected, actual, "Номер телефона введен неправильно");
        }

        ////////////////////////////////////////

        [Test(Description = "Тест геттера BirthDate")]
        public void TestBirthDateGet_CorrectValue()
        {
            var expected = new DateTime(1999, 10, 16);
            _contact.BirthDate = expected;
            var actual = _contact.BirthDate;
            Assert.AreEqual(expected, actual, "Геттер BirthDate возвращает неправильную дату");
        }

        [Test(Description = "Позитивный тест сеттера BirthDate")]
        public void TestBirthDateSet_CorrectValue()
        {
            var expected = new DateTime(1999, 10, 16);
            _contact.BirthDate = expected;
            var actual = _contact.BirthDate;
            Assert.AreEqual(expected, actual, "Дата введена неправильно");
        }

        [Test(Description = "Негативный тест сеттера BirthDate(год < 1900)")]
        public void TestBirthDateSet_TooLowValue()
        {
            var wrongBirthDate = new DateTime(1000, 10, 16);
            Assert.Throws<ArgumentException>(() => { _contact.BirthDate = wrongBirthDate; }, "должно возникать исключение, если год раньше 1900");
        }

        [Test(Description = "Негативный тест сеттера BirthDate(введеный дата больше текущей)")]
        public void TestBirthDateSet_TooBigValue()
        {
            var wrongBirthDate = new DateTime(3000, 10, 16);
            Assert.Throws<ArgumentException>(() => { _contact.BirthDate = wrongBirthDate; }, "должно возникать исключение, если введеная дата больше текущей");
        }

        ////////////////////////////////////////

        [Test(Description = "Тест геттера Email")]
        public void TestEmailGet_CorrectValue()
        {
            var expected = "ssas@mail.ru";
            _contact.Email = expected;
            var actual = _contact.Email;
            Assert.AreEqual(expected, actual, "Геттер Email возвращает неправильную почту");
        }

        [Test(Description = "Позитивный тест сеттера Email")]
        public void TestEmailSet_CorrectValue()
        {
            var expected = "ssas@mail.ru";
            _contact.Email = expected;
            var actual = "ssas@mail.ru";
            Assert.AreEqual(expected, actual, "Почта введена неправильно");
        }

        [Test(Description = "Негативный тест сеттера Email")]
        public void TestEmailSet_InCorrectValue()
        {
            var wrongemail = "ssadfghjklkjhgfdfghjklkjhgcvbnmnbvcxcvbnm,fdtyuioiuytrtyuioohgffghjkjgftyuiytrtyuioiuytrtyuiiuytrtyuiohgffghjklkjhghjkkjhgfghjjhgfghjhgfgs@mail.ru";
            Assert.Throws<ArgumentException>(() => { _contact.Name = wrongemail; }, "должно возникать исключение, если почта длиннее 50 символов");
        }

        ////////////////////////////////////////

        [Test(Description = "Тест геттера VKId")]
        public void TestVKidGet_CorrectValue()
        {
            var expected = "1233456";
            _contact.VKId = expected;
            var actual = _contact.VKId;
            Assert.AreEqual(expected, actual, "Геттер VKid возвращает неправильный айди");
        }

        [Test(Description = "Позитивный тест сеттера VKId")]
        public void TestVKidSet_CorrectValue()
        {
            var expected = "123456";
            _contact.Email = expected;
            var actual = "123456";
            Assert.AreEqual(expected, actual, "вк-айди введен неправильно");
        }

        [Test(Description = "Негативный тест сеттера VKId")]
        public void TestVKidSet_InCorrectValue()
        {
            var wrongevkId = "123123123123123123123123123123123123";
            Assert.Throws<ArgumentException>(() => { _contact.VKId = wrongevkId; }, "должно возникать исключение, если вк-айди длиннее 15 символов");
        }
    }
}

