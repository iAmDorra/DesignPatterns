namespace SuppliesWholesale
{
    public interface ICloaneableOrder
    {
        int Id { get; }
        string Label { get; }

        ICloaneableOrder Clone();
    }
}