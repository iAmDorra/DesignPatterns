using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMaker
{
    public class CheeseburgerBuilder : IBurgerBuilder
    {
        private class Cheeseburger : IBurger
        {
            private List<IIngredient> ingredients = new List<IIngredient>();
            public List<IIngredient> Ingredients => ingredients;
        }

        private IBurger cheeseburger;

        public CheeseburgerBuilder()
        {
            this.cheeseburger = new Cheeseburger();
        }

        public IBurgerBuilder AddKetchup(PortionSize portionSize)
        {
            this.cheeseburger.Ingredients.Add(new Ketchup(portionSize));
            return this;
        }
        
        public IBurgerBuilder AddOnion(PortionSize portionSize)
        {
            this.cheeseburger.Ingredients.Add(new Onion(portionSize));
            return this;
        }

        public IBurgerBuilder AddMayonnaise(PortionSize portionSize)
        {
            this.cheeseburger.Ingredients.Add(new Mayonnaise(portionSize));
            return this;
        }

        public IBurger GetBurger()
        {
            return this.cheeseburger;
        }
    }
}
