using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyHelloWorld;


namespace MyHelloWorldTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", Program.SayHello());
        }
    }
}
