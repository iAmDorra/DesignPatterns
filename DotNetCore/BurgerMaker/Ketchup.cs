namespace BurgerMaker
{
    internal class Ketchup : IIngredient
    {
        private PortionSize portionSize;

        public Ketchup(PortionSize portionSize)
        {
            this.portionSize = portionSize;
        }

        public PortionSize Size => portionSize;
    }
}