using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week2AssessmentQuestion2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AssessmentQuestion2.Tests
{
    [TestClass()]
    public class LicenseWaitingTimeTests
    {
        [TestMethod()]
        public void LicenseTest()
        {
            Random rnd = new Random();
            LicenseWaitingTime wt = new LicenseWaitingTime();
            List<string> list = new List<string>() { "Paarkavi", "Priya", "Vartha" };
            wt.License("Dwaraka", rnd.Next(3), list);
            int Expected = 60; //20==> correct answer
            Assert.AreEqual(Expected, wt.ResultantIndex);
            
        }
    }
}