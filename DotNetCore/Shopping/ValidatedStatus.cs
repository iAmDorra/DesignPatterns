using System;
using System.Collections.Generic;

namespace Shopping
{
    public class ValidatedStatus : OrderStatus
    {
        public ValidatedStatus(List<Item> items) : base(items)
        {
        }

        public override void AddItem(Item item)
        {
            throw new NotSupportedException();
        }

        public override OrderStatus NextStatus()
        {
            return new DeliveredStatus(this.items);
        }

        public override void RemoveItem(Item item)
        {
            this.items.Remove(item);
        }
    }
}
