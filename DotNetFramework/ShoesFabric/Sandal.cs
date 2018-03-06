namespace ShoesFabric
{
    internal class Sandal : IShoe
    {
        private ShoeType type;

        public Sandal(ShoeType leather)
        {
            this.type = leather;
        }
    }
}