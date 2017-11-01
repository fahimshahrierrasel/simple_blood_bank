using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blood_Bank_Management.Tests
{
    [TestClass]
    public class GetAvailablePacksForBloodGroup_Should
    {
        [TestMethod()]
        public void GetAvailablePacksForBloodGroupTest()
        {
            // arrange
            var bankController = new BankController();
            var sampleBloodGroup = 2;
            // act
            var totalPack = bankController.GetAvailablePacksForBloodGroup(sampleBloodGroup);
            // assert
            Assert.AreEqual(4, totalPack);
        }

        [TestMethod()]
        public void CanReciptBloodTest()
        {
            // arrange
            var bankController = new BankController();
            var sampleBloodGroup = 2;
            // act
            var status = bankController.CanReciptBlood(10, sampleBloodGroup);
            // assert
            Assert.AreEqual(false, status);
        }
        
        
    }
}
