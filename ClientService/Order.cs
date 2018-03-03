using System;
using System.Collections.Generic;

namespace ClientService
{
    public class Order
    {
        private List<Option> options = new List<Option>();

        internal void AddNewOption(Option option)
        {
            this.options.Add(option);
        }
    }
}