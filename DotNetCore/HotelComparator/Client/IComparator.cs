using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelComparator.Client
{
    public interface IComparator
    {
        //+ GetRoomAvailailities(Date) : List<RoomAvailability>
        List<RoomAvailability> GetRoomAvailailities(DateTime date);
    }
}
