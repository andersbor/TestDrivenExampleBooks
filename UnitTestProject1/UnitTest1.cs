using System;
using BooksForTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Book _book;

        [TestInitialize]
        public void Init()
        {
            _book = new Book();
        }

        [TestMethod]
        public void TestAuthor()
        {
            _book.Author = "Anders";
            Assert.AreEqual("Anders", _book.Author);
            _book.Author = "Anders B";
            Assert.AreEqual("Anders B", _book.Author);
        }

        [TestMethod]
        public void TestPrice()
        {
            _book.Price = 10.0/3.0;
            Assert.AreEqual(3.3333, _book.Price, 0.001);

            try
            {
                _book.Price = -0.01;
                Assert.Fail();
            } catch (ArgumentOutOfRangeException ex) { }

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIllegalPrice()
        {
            _book.Price = -0.01;

        }

        //[TestMethod]
        public void TestToString()
        {
            _book.Author = "John";
            _book.Title = "My first book";
            _book.Price = 9.10;
            string result = _book.ToString();
            Assert.AreEqual("John My first book 9,1", result);
        }
    }
}
