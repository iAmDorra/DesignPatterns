using System.Collections.Generic;

namespace BurgerMaker
{
    public interface IBurger
    {
        List<IIngredient> Ingredients { get; }
    }

}