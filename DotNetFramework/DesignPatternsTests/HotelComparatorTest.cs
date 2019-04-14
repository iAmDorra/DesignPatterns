using HotelComparator.AccoHotelService;
using HotelComparator.MyApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using NSubstitute;
using System;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class HotelComparatorTest
    {
        [TestMethod]
        public void Should_adapt_room_availabilities()
        {
            var myComparator = Substitute.For<HotelComparator.MyApplication.IComparator>();
            DateTime today = DateTime.Now.Date;
            myComparator.GetAvailableRooms(today).Returns(
                new System.Collections.Generic.List<RoomPrice>
                {
                    new RoomPrice(today,
                        new Room(301, RoomType.Double),
                        new Price(125, "EUR"))
                });

            var adaptor = new ComparatorAdaptor(myComparator);
            var rooms = adaptor.GetRoomAvailailities(today);

            Check.That(rooms.Count).IsEqualTo(1);
            Check.That(rooms[0].Date).IsEqualTo(today);
            Check.That(rooms[0].Price.Amount).IsEqualTo(125);
            Check.That(rooms[0].Price.Currency).IsEqualTo("EUR");
            Check.That(rooms[0].RoomInformation.RoomNumber).IsEqualTo(301);
            Check.That(rooms[0].RoomInformation.RoomType).IsEqualTo("Double");
        }
    }
}
