using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BooksForTesting.Tests
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void ToStringTest()
        {
            Book book = new Book();
            book.Author = "An";
            book.Author = "B";
            book.Author = null;
            book.Price = -0.1;
        }
    }
}