namespace AtDentist
{
    public interface IIterator
    {
        bool HasNext();
        IElement Next();
    }
}