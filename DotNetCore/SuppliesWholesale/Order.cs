namespace SuppliesWholesale
{
    public class Order : ICloaneableOrder
    {
        public Order(int id, string label)
        {
            this.Id = id;
            this.Label = label;
        }

        public int Id { get; private set; }
        public string Label { get; private set; }

        public ICloaneableOrder Clone()
        {
            return (ICloaneableOrder)this.MemberwiseClone();
        }
    }
}