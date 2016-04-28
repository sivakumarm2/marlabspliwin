using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PliWindowsApp;


namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // input valuaes
            int number1 = 10;
            int number2 = 20;
            int expected = 30;

            int actual=PliWindowsApp.Calculation.AddNumbers(number1, number2);
            Assert.AreEqual(expected, actual, "Result matching as expected");

        }
    }
}
