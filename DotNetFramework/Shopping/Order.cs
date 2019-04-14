using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Order
    {
        private OrderStatus status;
        private List<Item> items = new List<Item>();

        public List<Item> Items { get => items; }

        public Order()
        {
            // Can be passed into a parameter
            status = new InProgressStatus(Items);
        }
        
        public void AddItem(Item item)
        {
            status.AddItem(item);
        }

        public void RemoveItem(Item item)
        {
            status.RemoveItem(item);
        }

        public void NextStatus()
        {
            status = status.NextStatus();
        }
    }
}
