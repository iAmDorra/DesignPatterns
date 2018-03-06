namespace ShoesFabric
{
    public interface IShoeCreator
    {
        IShoe CreateLeatherSandal();
        IShoe CreateLeatherShoe();
        IShoe CreateSyntheticSandal();
        IShoe CreateSyntheticShoe();
    }
}