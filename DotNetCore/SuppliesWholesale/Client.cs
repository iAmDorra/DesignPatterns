using System;

namespace SuppliesWholesale
{
    public class Client
    {
        public ICloaneableOrder CreateOrderFromAnother(ICloaneableOrder order)
        { 
            return order.Clone();
        }
    }
}
