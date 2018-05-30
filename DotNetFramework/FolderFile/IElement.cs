namespace FolderFile
{
    public interface IElement
    {
        string Name { get; }
        void Accept(IWriter writer);
    }
}