using HotelComparator.AccoHotelService;
using System;
using System.Collections.Generic;

namespace HotelComparator
{
    public class Comparator
    {
        private readonly IAccoHotel accoHotel;

        public Comparator()
        {
            this.accoHotel = new AccoHotel();
        }
        public List<RoomPrice> GetAvailableRooms(DateTime date)
        {
            var rooms = accoHotel.GetAvailableRooms(date);
            var roomPrices = new List<RoomPrice>();
            foreach (var room in rooms)
            {
                var price = accoHotel.GetRoomPrice(room, date);
                var roomPrice = new RoomPrice(date, room, price);
                roomPrices.Add(roomPrice);
            }

            return roomPrices;
        }
    }
}
