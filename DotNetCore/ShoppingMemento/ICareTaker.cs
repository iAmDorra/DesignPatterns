namespace ShoppingMemento
{
    public interface ICareTaker
    {
        void SaveMemento(IMemento memento);
        IMemento GetMemento(int index);
    }
}