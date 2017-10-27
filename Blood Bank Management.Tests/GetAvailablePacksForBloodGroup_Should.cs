using Blood_Bank_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var sampleBloodGroup = 0;
            // act
            var totalPack = bankController.GetAvailablePacksForBloodGroup(sampleBloodGroup);
            // assert
            Assert.AreEqual(0, totalPack);
        }
    }
}
