using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestofConsoleApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int testMember = 1;
            Assert.AreEqual(1, testMember);
        }
    }
}
