using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MyHelloWorldLib;

namespace MyHelloWorldTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", HelloLib.SayHello());
        }
    }
}
