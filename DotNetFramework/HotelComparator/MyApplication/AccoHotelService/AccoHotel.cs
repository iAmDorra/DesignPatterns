using System;
using System.Collections.Generic;

namespace HotelComparator.AccoHotelService
{
    public class AccoHotel : IAccoHotel
    {
        public List<Room> GetAvailableRooms(DateTime date)
        {
            // Get from DB
            return new List<Room>
            {
                new Room(14, RoomType.Single),
                new Room(15, RoomType.Double)
            };
        }

        public Price GetRoomPrice(Room room, DateTime date)
        {
            // Get from DB
            var price = new Price(36, "EUR");
            return price;
        }
    }
}
