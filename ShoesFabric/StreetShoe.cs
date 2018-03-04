namespace ShoesFabric
{
    internal class StreetShoe : IShoe
    {
        private ShoeType type;

        public StreetShoe(ShoeType leather)
        {
            this.type = leather;
        }
    }
}