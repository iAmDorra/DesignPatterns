namespace CrepeMaker
{
    public class Crepe : IDessert
    {
        private readonly double price;

        public Crepe(double price)
        {
            this.price = price;
        }

        public double GetPrice()
        {
            return this.price;
        }
    }
}
