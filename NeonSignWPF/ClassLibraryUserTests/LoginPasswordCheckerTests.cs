using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUser.Tests
{
    [TestClass()]
    public class LoginPasswordCheckerTests
    {
        [TestMethod()]
        public void Check_EmptyPass_False()
        {
            //Arrange.
            string password = "";
            string login = "login";
            //Act.
            bool actual = LoginPasswordChecker.ValidateUser(password, login);
            //Assert.
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_5Char_False()
        {
            //Arrange.
            string password = "null";
            string login = "login";
            //Act.
            bool actual = LoginPasswordChecker.ValidateUser(password, login);
            //Assert.
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_5Char_True()
        {
            //Arrange.
            string password = "passwordddddd";
            string login = "login";
            //Act.
            bool actual = LoginPasswordChecker.ValidateUser(password, login);
            //Assert.
            Assert.IsTrue(actual);
        }
        [TestMethod()]
        public void Check_WrongData()
        {
            //Arrange.
            string password = "nopas";
            string login = "notlogin";
            //Act.
            bool actual = LoginPasswordChecker.ValidateUser(password, login);
            //Assert.
            Assert.IsTrue(actual);
        }
        [TestMethod()]
        public void Check_RightData()
        {
            //Arrange.
            string password = "password";
            string login = "login";
            //Act.
            bool actual = LoginPasswordChecker.ValidateUser(password, login);
            //Assert.
            Assert.IsTrue(actual);
        }
    }
}