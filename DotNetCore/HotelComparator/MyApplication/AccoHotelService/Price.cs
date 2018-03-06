namespace HotelComparator.AccoHotelService
{
    public class Price
    {
        private double price;
        private string currency;

        public Price(double price, string currency)
        {
            this.price = price;
            this.currency = currency;
        }

        public double Amount { get => this.price; }
        public string Currency { get => this.currency; }
    }
}