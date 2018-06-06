namespace ShoppingMemento
{
    public class Memento : IMemento
    {
        private OrderStatus status;

        public Memento(OrderStatus status)
        {
            this.status = status;
        }

        public OrderStatus Status
        {
            get
            {
                return status;
            }
        }
    }
}
