namespace BurgerMaker
{
    public interface IBurgerBuilder
    {
        IBurgerBuilder AddKetchup(PortionSize portionSize);
        IBurgerBuilder AddOnion(PortionSize portionSize);
        IBurgerBuilder AddMayonnaise(PortionSize portionSize);
        IBurger GetBurger();
    }
}
