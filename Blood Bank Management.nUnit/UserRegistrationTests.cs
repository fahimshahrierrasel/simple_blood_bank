using System;
using NUnit.Framework;

namespace Blood_Bank_Management.nUnit
{
    [TestFixture]
    public class UserRegistrationTests
    {
        [TestCase]
        public void HasEnoughDateToDonateTest()
        {
            // arrange
            var userController = new UserController();
            var dob = new DateTime(1990, 1, 1);
            // act
            var hasAge = userController.HasEnoughAgeToDonate(dob);
            // assert
            Assert.AreEqual(true, hasAge);
        }

        [TestCase]
        public void ValidateRegistrationDataTest()
        {
            // arrange
            var userController = new UserController();
            var userName = "Fahim Shahrier Rasel";
            var dob = new DateTime(1990, 1, 1);
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
