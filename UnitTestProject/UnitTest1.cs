using System;
using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_testing_for_testing;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Book book1 = new Book("Ae", 009);
            Book book2 = new Book("Fairy tale", 1250);
        }
    }
}
