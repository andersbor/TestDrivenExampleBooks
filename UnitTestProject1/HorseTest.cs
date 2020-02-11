using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class HorseTest
    {
        [TestMethod]
        public void TestLegs()
        {
            Horse horse = new Horse();
            Assert.AreEqual(horse.Legs, 4);

        }
    }

    internal class Horse
    {
        public int Legs { get; set; }
    }
}
