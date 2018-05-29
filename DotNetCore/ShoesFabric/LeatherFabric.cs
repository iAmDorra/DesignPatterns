namespace ShoesFabric
{
    internal class LeatherFabric : ShoeCreator
    {
        public override Sandal CreateSandal()
        {
            return new LeatherSandal();
        }

        public override StreetShoe CreateShoe()
        {
            return new LeatherStreetShoe();
        }
    }
}
