namespace CarDealer
{
    internal class LuxembourgishOrder : BaseOrder
    {
        private double preTaxServiceAmount;
        private double preTaxMaterialAmount;

        public LuxembourgishOrder(double preTaxServiceAmount, double preTaxMaterialAmount)
        {
            this.preTaxServiceAmount = preTaxServiceAmount;
            this.preTaxMaterialAmount = preTaxMaterialAmount;
        }

        protected override double CalculatePreTaxAmount()
        {
            return this.preTaxServiceAmount * 0.12 +
                this.preTaxMaterialAmount * 0.15;
        }

        protected override double CalculateVat()
        {
            return this.preTaxServiceAmount + this.preTaxMaterialAmount;
        }
    }
}
