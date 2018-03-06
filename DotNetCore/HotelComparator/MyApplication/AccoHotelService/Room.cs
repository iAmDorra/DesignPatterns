namespace HotelComparator.AccoHotelService
{
    public class Room
    {
        private int roomNumber;
        private readonly RoomType type;

        public Room(int roomNumber, RoomType type)
        {
            this.roomNumber = roomNumber;
            this.type = type;
        }

        public int Number { get => this.roomNumber; }
    }
}