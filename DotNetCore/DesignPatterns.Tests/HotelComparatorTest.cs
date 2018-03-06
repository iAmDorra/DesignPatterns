using HotelComparator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesignPatterns.Tests
{
    [TestClass]
    class HotelComparatorTest
    {
        [TestMethod]
        public void Should()
        {
            var comparator = new Comparator();

            var rooms = comparator.GetAvailableRooms(DateTime.Now);
            
            Assert.IsNotNull(rooms);
        }
    }
}
