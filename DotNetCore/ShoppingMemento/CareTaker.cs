using System.Collections.Generic;

namespace ShoppingMemento
{
    public class CareTaker : ICareTaker
    {
        private List<IMemento> mementos = new List<IMemento>();

        public void SaveMemento(IMemento memento)
        {
            this.mementos.Add(memento);
        }

        public IMemento GetMemento(int index)
        {
            return this.mementos[index];
        }
    }
}
