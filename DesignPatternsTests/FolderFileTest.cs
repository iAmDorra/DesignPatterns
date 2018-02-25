using Microsoft.VisualStudio.TestTools.UnitTesting;
using FolderFile;
using NFluent;
using System.Collections.Generic;

namespace DesignPatterns
{
    [TestClass]
    public class FolderFileTest
    {
        [TestMethod]
        public void Should_folder_contains_one_element_when_gettings_contains()
        {
            var textFile = new File { Name = "data.txt" };
            var parentFolder = new Folder { Name = "Parent Folder" };
            parentFolder.Files = new List<File> { textFile };

            var containsNumber = parentFolder.GetContainsNumber();

            Check.That(containsNumber).IsEqualTo(1);
        }

        [TestMethod]
        public void Should_folder_contains_three_elements_when_gettings_contains()
        {
            var folder = CreateFolderTree();

            var containsNumber = folder.GetContainsNumber();

            Check.That(containsNumber).IsEqualTo(2);
        }

        private static Folder CreateFolderTree()
        {
            var textFile = new File { Name = "data.txt" };
            var firstFolder = new Folder { Name = "Data Folder" };
            var secondFolder = new Folder { Name = "Folder" };

            var parentFolder = new Folder { Name = "Parent Folder" };
            parentFolder.Files = new List<File> { textFile };
            parentFolder.Folders = new List<Folder> { firstFolder };

            return parentFolder;
        }
    }
}
