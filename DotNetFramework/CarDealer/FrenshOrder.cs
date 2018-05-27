namespace CarDealer
{
    internal class FrenshOrder : BaseOrder
    {
        private double preTaxAmount;

        public FrenshOrder(double preTaxAmount)
        {
            this.preTaxAmount = preTaxAmount;
        }

        protected override double CalculatePreTaxAmount()
        {
            return this.preTaxAmount * 0.196;
        }

        protected override double CalculateVat()
        {
            return this.preTaxAmount;
        }
    }
}
