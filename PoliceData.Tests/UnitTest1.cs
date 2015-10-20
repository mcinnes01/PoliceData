using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Police.Core;

namespace PoliceData.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAresponse()
        {
            var service = new Service();
            var crimes = service.GetCrimes();
            Assert.IsTrue(crimes.Result.Count > 0);
        }
    }
}
