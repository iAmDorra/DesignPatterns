namespace ShoesFabric
{
    internal class LeatherFabric : ShoeCreator
    {
        public Sandal CreateSandal()
        {
            return new LeatherSandal();
        }

        public StreetShoe CreateShoe()
        {
            return new LeatherStreetShoe();
        }
    }
}
