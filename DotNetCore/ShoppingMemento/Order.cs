using System.Collections.Generic;

namespace ShoppingMemento
{
    public class Order : IMementoOriginator
    {
        private OrderStatus status;
        private List<Item> items = new List<Item>();

        public List<Item> Items { get => items; }

        public Order()
        {
            // Can be passed into a parameter
            status = new InProgressStatus(Items);
        }

        public IMemento CreateMemento()
        {
            return new Memento(this.status);
        }

        public void RestoreMemento(IMemento memento)
        {
            this.status = memento.Status;
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
