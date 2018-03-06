using HotelComparator;
using HotelComparator.AccoHotelService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Check.That(rooms).IsNotNull();
        }
    }
}
