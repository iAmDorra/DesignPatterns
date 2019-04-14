namespace ShoesFabric
{
    internal class SyntheticFabric : ShoeCreator
    {
        public Sandal CreateSandal()
        {
            return new SyntheticSandal();
        }

        public StreetShoe CreateShoe()
        {
            return new SyntheticStreetShoe();
        }
    }
}
