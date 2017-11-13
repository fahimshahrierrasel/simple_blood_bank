using Blood_Bank_Management;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blood_Bank_Management.Tests
{
    [TestClass]
    public class UserRegistrationTests
    {
        [TestMethod]
        public void HasEnoughAgeToDonateTest()
        {
            // arrange
            var userController = new UserController();
            var dob = new DateTime(1990, 1, 1);
            // act
            var hasAge = userController.HasEnoughAgeToDonate(dob);
            // assert
            Assert.AreEqual(true, hasAge);
        }

        [TestMethod()]
        public void ValidateRegistrationDataTest()
        {
            // arrange
            var userController = new UserController();
            var userName = "Fahim Shahrier Rasel";
            var dob = DateTime.Now;
            var weight = 50;
            var mobileNumber = "01554070646";
            var address = "Middle Badda";
            
            // act
            var isValid = userController.ValidateRegistrationData(userName, dob, weight, mobileNumber, address);
            // assert
            Assert.AreEqual(true, isValid);
        }
    }
}
