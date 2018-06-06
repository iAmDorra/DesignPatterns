using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShoppingMemento;
using NFluent;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class ShoppingMementoTest
    {
        [TestMethod]
        public void Should_throw_exception_when_to_add_item_with_validated_status()
        {
            var order = new Order();
            var careTaker = new CareTaker();

            careTaker.SaveMemento(order.CreateMemento());

            order.AddItem(new Item());
            order.NextStatus();

            Check.ThatCode(() =>
            {
                order.AddItem(new Item());
            }).Throws<NotSupportedException>();
        }

        [TestMethod]
        public void Should_restore_to_inprogress_status_when_get_memento_for_validated_status()
        {
            var order = new Order();
            var careTaker = new CareTaker();

            careTaker.SaveMemento(order.CreateMemento());
            Item firstItem = new Item();
            order.AddItem(firstItem);
            Item secondItem = new Item();
            order.AddItem(secondItem);
            order.NextStatus();
            careTaker.SaveMemento(order.CreateMemento());

            order.RestoreMemento(careTaker.GetMemento(0));
            Item thirdItem = new Item();
            order.AddItem(thirdItem);

            Check.That(order.Items.Count).IsEqualTo(3);
        }
    }
}
