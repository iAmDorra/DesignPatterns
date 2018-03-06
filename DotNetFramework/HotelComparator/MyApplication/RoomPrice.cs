using System;
using HotelComparator.AccoHotelService;

namespace HotelComparator
{
    public class RoomPrice
    {
        public RoomPrice(DateTime date, Room room, Price price)
        {
            Date = date;
            Room = room;
            Price = price;
        }

        public Room Room { get; internal set; }
        public Price Price { get; internal set; }
        public DateTime Date { get; internal set; }
    }
}