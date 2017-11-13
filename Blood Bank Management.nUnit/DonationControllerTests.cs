using System;
using NUnit.Framework;


namespace Blood_Bank_Management.nUnit
{
    [TestFixture]
    class DonationControllerTests
    {
        DonationController donatationController = new DonationController();

        [TestCase]
        public void DiferenceBetweenLastDonationTest()
        {
            // arrange
            var donationToday = DateTime.Today;
            var donationOtherDay = DateTime.Parse("21/02/2018");
            // act
            var totalDifference = donatationController.DiferenceBetweenLastDonation(donationToday.ToString("d"));
            Console.WriteLine(totalDifference);
            // assert
            Assert.LessOrEqual(90.0d, totalDifference);
            
        }
    }
}
