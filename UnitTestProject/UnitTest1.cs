using System;
using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_testing_for_testing;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private Book book;
        private int _maxYear = 2016;
        private int _minYear = 1100;
        private string _titleShort = "A";
        private string _titleRight = "A fairy tale";

        [TestInitialize]
        public void BeforeTest()
        {
            book = new Book();
        }

        [TestMethod]
        [ExpectedException(typeof(TitleTooShortException))]
        public void TestConstructorShortTitle()
        {
            book = new Book(_titleShort, _minYear);
        }

        [TestMethod]
        [ExpectedException(typeof(IncorrectYearException))]
        public void TestConstructorIncorrectYear()
        {
            book = new Book(_titleRight, _minYear-1);
        }

        [TestMethod]
        public void TestConstructor()
        {
            book = new Book(_titleRight, _minYear);
            
            Assert.AreEqual("A fairy tale", book.Title);
            Assert.AreEqual(_minYear, book.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(TitleTooShortException))]
        public void TestTitleTooShort()
        {
            book.Title = _titleShort;
        }

        [TestMethod]
        public void TestTitleRight()
        {
            book.Title = _titleRight;

            Assert.AreEqual("A fairy tale", book.Title);
        }

        [TestMethod]
        [ExpectedException(typeof(IncorrectYearException))]
        public void TestMinimumYear()
        {
            book.Year = _minYear-1;           
        }

        [TestMethod]
        [ExpectedException(typeof (IncorrectYearException))]
        public void TestMaximumYear()
        {
            book.Year = _maxYear + 1;
        }

        [TestMethod]
        public void TestYear()
        {
            book.Year = 1600;

            Assert.AreEqual(1600, book.Year);
        }
    }
}
