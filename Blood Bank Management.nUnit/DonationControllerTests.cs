using System;
using NUnit.Framework;


namespace Blood_Bank_Management.nUnit
{
    [TestFixture]
    class DonationControllerTests
    {
        DonationController  donatationController = new DonationController();

        [TestCase]
        public void DiferenceBetweenLastDonationTest()
        {
            // arrange
            var donationToday = DateTime.Today;
            var donationOtherDay = DateTime.Parse("21/05/2018");
            // act
            var totalDifference = donatationController.DiferenceBetweenLastDonation(donationOtherDay.ToString("d"));
            // assert
            Assert.AreEqual(true, totalDifference >= 90.0d);

        }
    }
}
