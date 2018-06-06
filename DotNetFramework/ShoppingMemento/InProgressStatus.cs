using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingMemento
{
    public class InProgressStatus : OrderStatus
    {
        public InProgressStatus(List<Item> items) : base(items)
        {
        }

        public override void AddItem(Item item)
        {
            this.items.Add(item);
        }

        public override OrderStatus NextStatus()
        {
            return new ValidatedStatus(this.items);
        }

        public override void RemoveItem(Item item)
        {
            this.items.Remove(item);
        }
    }
}
