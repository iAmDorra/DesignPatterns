using System.Collections.Generic;

namespace FolderFile
{
    public class Folder : IElement, IReferenceableElement
    {
        private string name;
        private List<IElement> elements;

        public Folder(string name)
        {
            this.name = name;
            this.elements = new List<IElement>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public List<IElement> Elements
        {
            get
            {
                return elements;
            }
        }

        public void Accept(IWriter writer)
        {
            writer.Write(this);
        }

        public int GetContainsNumber()
        {
            return Elements.Count;
        }
    }
}
