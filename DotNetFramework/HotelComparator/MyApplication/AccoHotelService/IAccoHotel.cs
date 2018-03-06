using System;
using System.Collections.Generic;

namespace HotelComparator.AccoHotelService
{
    public interface IAccoHotel
    {
        List<Room> GetAvailableRooms(DateTime date);
        Price GetRoomPrice(Room room, DateTime date);
    }
}