namespace BurgerMaker
{
    internal class Mayonnaise : IIngredient
    {
        private PortionSize portionSize;

        public Mayonnaise(PortionSize portionSize)
        {
            this.portionSize = portionSize;
        }

        public PortionSize Size => portionSize;
    }
}