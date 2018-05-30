namespace ShoesFabricBridge
{
    internal class LeatherFabric : ShoeCreator
    {
        public override Sandal CreateSandal()
        {
            return new Sandal(new Leather());
        }

        public override StreetShoe CreateShoe()
        {
            return new StreetShoe(new Leather());
        }
    }
}
