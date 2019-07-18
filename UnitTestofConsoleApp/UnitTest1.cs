using Microsoft.VisualStudio.TestTools.UnitTesting;
using myConsoleApp;

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

        [TestMethod]
        public void TestMethod2()
        {
            //First   
            Trigonometric.TrianlgeSidesInput(10, 10, 10);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Second Test   
            Trigonometric.TrianlgeSidesInput(10.5, 10.5, 15);

        }

        [TestMethod]
        public void TestMethod4()
        {
            //Thisrd Test   
            Trigonometric.TrianlgeSidesInput(10.5, 12.5, 15.5);

        }
    }
}
