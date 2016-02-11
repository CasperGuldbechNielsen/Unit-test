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
            try
            {
                var book1 = new Book("Ae", 1600);
            }
            catch (TitleTooShortException)
            {
                Console.WriteLine("Title too short");
            }
            catch (IncorrectYearException)
            {
                Console.WriteLine("Incorrect year");
            }
            try
            {
                var book2 = new Book("Fairy tale", 1009);
            }
            catch (TitleTooShortException)
            {
                Console.WriteLine("Title too short");
            }
            catch (IncorrectYearException)
            {
                Console.WriteLine("Incorrect year");
            }
        }
    }
}
