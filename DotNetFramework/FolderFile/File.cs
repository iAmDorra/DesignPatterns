namespace FolderFile
{
    public class File : IElement, IReferenceableElement
    {
        private string name;
        public File(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public void Accept(IWriter writer)
        {
            writer.Write(this);
        }
    }
}
