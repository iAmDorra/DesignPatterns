namespace ShoesFabric
{
    internal class SyntheticFabric : ShoeCreator
    {
        public override Sandal CreateSandal()
        {
            return new SyntheticSandal();
        }

        public override StreetShoe CreateShoe()
        {
            return new SyntheticStreetShoe();
        }
    }
}
