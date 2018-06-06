using System.Collections.Generic;

namespace ShoppingMemento
{
    public abstract class OrderStatus
    {
        protected List<Item> items;

        public OrderStatus(List<Item> items)
        {
            this.items = items;
        }

        public abstract void AddItem(Item item);
        public abstract void RemoveItem(Item item);
        public abstract OrderStatus NextStatus();
    }
}