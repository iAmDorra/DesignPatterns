namespace CarDealer
{
    internal abstract class BaseOrder : IOrder
    {
        public double CalculateAmount()
        {
            return CalculateVat() + CalculatePreTaxAmount();
        }

        protected abstract double CalculateVat();
        protected abstract double CalculatePreTaxAmount();
    }
}
