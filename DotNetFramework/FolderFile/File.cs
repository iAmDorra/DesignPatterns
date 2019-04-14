namespace FolderFile
{
    public class File : IElement
    {
        public File(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
    }
}
