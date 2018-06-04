using BurgerMaker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class BurgerMakerTest
    {
        [TestMethod]
        public void Should_build_a_cheeseburger_without_ingredients()
        {
            var cheeseburgerBuilder = new CheeseburgerBuilder();
            var burger = cheeseburgerBuilder.GetBurger();
            Check.That(burger.Ingredients.Count).IsEqualTo(0);
        }

        [TestMethod]
        public void Should_build_a_cheeseburger_with_ketchup()
        {
            var cheeseburgerBuilder = new CheeseburgerBuilder();
            cheeseburgerBuilder.AddKetchup(PortionSize.Extra);
            var burger = cheeseburgerBuilder.GetBurger();
            Check.That(burger.Ingredients[0].Size).IsEqualTo(PortionSize.Extra);
        }

        [TestMethod]
        public void Should_build_a_cheeseburger_with_ketchup_and_onion()
        {
            var cheeseburgerBuilder = new CheeseburgerBuilder();
            cheeseburgerBuilder.AddKetchup(PortionSize.Extra)
                .AddOnion(PortionSize.Light);
            var burger = cheeseburgerBuilder.GetBurger();
            Check.That(burger.Ingredients.Count).IsEqualTo(2);
            Check.That(burger.Ingredients[0].Size).IsEqualTo(PortionSize.Extra);
            Check.That(burger.Ingredients[1].Size).IsEqualTo(PortionSize.Light);
        }

        [TestMethod]
        public void Should_build_a_cheeseburger_with_ketchup_and_onion_and_mayonnaise()
        {
            IBurgerBuilder cheeseburgerBuilder = new CheeseburgerBuilder();
            cheeseburgerBuilder.AddKetchup(PortionSize.Extra)
                .AddOnion(PortionSize.Light)
                .AddMayonnaise(PortionSize.Medium);
            var burger = cheeseburgerBuilder.GetBurger();
            Check.That(burger.Ingredients.Count).IsEqualTo(3);
            Check.That(burger.Ingredients[0].Size).IsEqualTo(PortionSize.Extra);
            Check.That(burger.Ingredients[1].Size).IsEqualTo(PortionSize.Light);
            Check.That(burger.Ingredients[2].Size).IsEqualTo(PortionSize.Medium);
        }
    }
}
