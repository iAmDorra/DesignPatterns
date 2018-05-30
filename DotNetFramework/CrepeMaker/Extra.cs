namespace CrepeMaker
{
    public abstract class Extra : IDessert
    {
        protected readonly double price;
        protected readonly IDessert dessert;

        public Extra(double price, IDessert dessert)
        {
            this.price = price;
            this.dessert = dessert;
        }

        public double GetPrice()
        {
            return this.price + this.dessert.GetPrice();
        }
    }
}
