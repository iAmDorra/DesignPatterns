using System.Collections.Generic;

namespace FolderFile
{
    public class Folder : IElement
    {
        public Folder(string name)
        {
            this.Name = name;
            this.Elements = new List<IElement>();
        }

        public string Name { get; }

        public List<IElement> Elements { get; }

        public int GetContainsNumber()
        {
            return Elements.Count;
        }
    }
}
