using HotelComparator.Client;
using System;
using System.Collections.Generic;

namespace HotelComparator.MyApplication
{
    public class ComparatorAdaptor : Client.IComparator
    {
        private MyApplication.IComparator myComparator;

        public ComparatorAdaptor(MyApplication.IComparator myAppComparator)
        {
            myComparator = myAppComparator;
        }

        public List<RoomAvailability> GetRoomAvailailities(DateTime date)
        {
            var roomPrices = myComparator.GetAvailableRooms(date);
            List<RoomAvailability> prices = new List<RoomAvailability>();
            foreach (var room in roomPrices)
            {
                var availability = new RoomAvailability();
                availability.Date = room.Date;
                availability.Price = new Price
                {
                    Amount = room.Price.Amount,
                    Currency = room.Price.Currency
                };
                availability.RoomInformation = new RoomInformation
                {
                    RoomNumber = room.Room.Number,
                    RoomType = room.Room.Type.ToString()
                };
                prices.Add(availability);
            }

            return prices;
        }
    }
}
