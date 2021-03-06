﻿using System;
using NUnit.Framework;

namespace Blood_Bank_Management.nUnit
{
    [TestFixture]
    public class UserRegistrationTests
    {
        [TestCase]
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

        [TestCase]
        public void StringCorrectTest()
        {
            // arrange
            var userController = new UserController();
            var aString = "String";
            // act
            var isString = userController.StringHasSomeValue(aString);
            // assert
            Assert.AreEqual(true, isString);
        }

        [TestCase]
        public void MobileNumberCorrectTest()
        {
            // arrange
            var userController = new UserController();
            var mobileNumber = "01554070646";
            // act
            var isMobileNumber = userController.IsMobileNumber(mobileNumber);
            // assert
            Assert.AreEqual(true, isMobileNumber);
        }

        [TestCase]
        public void ValidateCorrectRegistrationDataTest()
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
        [TestCase]
        public void ValidateNullNameRegistrationDataTest()
        {
            // arrange
            var userController = new UserController();
            string userName = null;
            var dob = new DateTime(1990, 1, 1);
            var weight = 50;
            var mobileNumber = "01554070646";
            var address = "Middle Badda";

            // assert
            Assert.Throws<NullReferenceException>(() =>
                userController.ValidateRegistrationData(userName, dob, weight, mobileNumber, address));
        }

        [TestCase]
        public void ValidateNotEnoughAgeRegistrationDataTest()
        {
            // arrange
            var userController = new UserController();
            string userName = "Fahim Shahrier Rasel";
            var dob = new DateTime(2010, 1, 1);
            var weight = 50;
            var mobileNumber = "01554070646";
            var address = "Middle Badda";
            // act
            var isValid = userController.ValidateRegistrationData(userName, dob, weight, mobileNumber, address);
            // assert
            Assert.AreEqual(false, isValid);
        }

        [TestCase]
        public void ValidateUnderWeightRegistrationDataTest()
        {
            // arrange
            var userController = new UserController();
            string userName = "Fahim Shahrier Rasel";
            var dob = new DateTime(1990, 1, 1);
            var weight = 46;
            var mobileNumber = "01554070646";
            var address = "Middle Badda";
            // act
            var isValid = userController.ValidateRegistrationData(userName, dob, weight, mobileNumber, address);
            // assert
            Assert.AreEqual(false, isValid);
        }

        [TestCase]
        public void ValidateIncorrectMobileNumberRegistrationDataTest()
        {
            // arrange
            var userController = new UserController();
            string userName = "Fahim Shahrier Rasel";
            var dob = new DateTime(1990, 1, 1);
            var weight = 50;
            var mobileNumber = "015540BBSA70646";
            var address = "Middle Badda";
            // act
            var isValid = userController.ValidateRegistrationData(userName, dob, weight, mobileNumber, address);
            // assert
            Assert.AreEqual(false, isValid);
        }

        [TestCase]
        public void ValidateNullAddressRegistrationDataTest()
        {
            // arrange
            var userController = new UserController();
            string userName = "Fahim Shahrier Rasel";
            var dob = new DateTime(1990, 1, 1);
            var weight = 50;
            var mobileNumber = "01554070646";
            string address = null;

            // assert
            Assert.Throws<NullReferenceException>(() =>
                userController.ValidateRegistrationData(userName, dob, weight, mobileNumber, address));
        }

    }
}
