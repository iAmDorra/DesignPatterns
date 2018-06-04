namespace BurgerMaker
{
    internal class Onion : IIngredient
    {
        private PortionSize portionSize;

        public Onion(PortionSize portionSize)
        {
            this.portionSize = portionSize;
        }

        public PortionSize Size => portionSize;
    }
}