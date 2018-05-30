using System;

namespace FolderFile
{
    public class NameWriter : IWriter
    {
        public void Write(IElement element)
        {
            element.Accept(this);
        }

        public void Write(Link link)
        {
            Console.WriteLine(link.Name);
        }

        public void Write(File file)
        {
            Console.WriteLine(file.Name);
        }

        public void Write(Folder folder)
        {
            Console.WriteLine(folder.Name);
            foreach (var item in folder.Elements)
            {
                this.Write(item);
            }
        }
    }
}
