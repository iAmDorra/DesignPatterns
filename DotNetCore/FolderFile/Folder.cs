using System.Collections.Generic;

namespace FolderFile
{
    public class Folder
    {
        public string Name { get; set; }

        public List<File> Files { get; set; }
        
        public List<Folder> Folders { get; set; }

        public int GetContainsNumber()
        {
            int filesCount = 0;
            if(Files != null)
            {
                filesCount = Files.Count;
            }

            int foldersCount = 0;
            if(Folders != null)
            {
                foldersCount = Folders.Count;
            }

            return filesCount + foldersCount;
        }
    }
}
