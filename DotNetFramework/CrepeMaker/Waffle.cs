namespace CrepeMaker
{
    public class Waffle : IDessert
    {
        private readonly double price;

        public Waffle(double price)
        {
            this.price = price;
        }

        public double GetPrice()
        {
            return this.price;
        }
    }
}
