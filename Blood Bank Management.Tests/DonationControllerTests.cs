using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blood_Bank_Management.Tests
{
    [TestClass]
    public class DonationControllerTests
    {
        DonationController donatationController = new DonationController();

        [TestMethod]
        public void DiferenceBetweenLastDonationTest()
        {
            // arrange
            var donationToday = DateTime.Today;
            var donationOtherDay = DateTime.Parse("21/02/2018");
            // act
            var totalDifference = donatationController.DiferenceBetweenLastDonation(donationOtherDay.ToString("d"));
            // assert
            
            Assert.AreEqual(true, totalDifference >= 90.0d);
        }
    }
}
