namespace FolderFile
{
    public class Link : IElement
    {
        private readonly string name;
        private readonly IReferenceableElement element;

        public Link(string name, IReferenceableElement element)
        {
            this.name = name;
            this.element = element;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public IReferenceableElement Reference
        {
            get
            {
                return this.element;
            }
        }
    }
}
