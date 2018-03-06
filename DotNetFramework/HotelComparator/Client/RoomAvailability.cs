using System;

namespace HotelComparator.Client
{
    public class RoomAvailability
    {
        public RoomInformation RoomInformation { get; set; }

        public DateTime Date { get; set; }

        public Price Price { get; set; }
    }
}
