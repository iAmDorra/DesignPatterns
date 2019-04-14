namespace ShoesFabric
{
    public interface ShoeCreator : IShoeCreator
    {
        StreetShoe CreateShoe();

        Sandal CreateSandal();
    }
}
