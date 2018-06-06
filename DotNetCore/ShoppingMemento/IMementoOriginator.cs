namespace ShoppingMemento
{
    public interface IMementoOriginator
    {
        IMemento CreateMemento();
        void RestoreMemento(IMemento memento);
    }
}