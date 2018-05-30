namespace ShoesFabricBridge
{
    internal class SyntheticFabric : ShoeCreator
    {
        public override Sandal CreateSandal()
        {
            return new Sandal(new Synthetic());
        }

        public override StreetShoe CreateShoe()
        {
            return new StreetShoe(new Synthetic());
        }
    }
}
