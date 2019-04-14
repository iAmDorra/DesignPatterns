using System;
using System.Collections.Generic;

namespace Shopping
{
    public class DeliveredStatus : OrderStatus
    {
        public DeliveredStatus(List<Item> items) : base(items)
        {
        }

        public override void AddItem(Item item)
        {
            throw new NotSupportedException();
        }

        public override OrderStatus NextStatus()
        {
            return this;
        }

        public override void RemoveItem(Item item)
        {
            throw new NotSupportedException();
        }
    }
}
