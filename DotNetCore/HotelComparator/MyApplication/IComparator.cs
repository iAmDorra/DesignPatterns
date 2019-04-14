using System;
using System.Collections.Generic;

namespace HotelComparator.MyApplication
{
    public interface IComparator
    {
        List<RoomPrice> GetAvailableRooms(DateTime date);
    }
}