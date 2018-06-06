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
            var textFile = new File("data.txt");
            var parentFolder = new Folder("Parent Folder");
            parentFolder.Elements.Add(textFile);

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
            var textFile = new File("data.txt");
            var firstFolder = new Folder("Data Folder");
            var secondFolder = new Folder("Folder");

            var parentFolder = new Folder("Parent Folder");
            parentFolder.Elements.Add(textFile);
            parentFolder.Elements.Add(firstFolder);

            return parentFolder;
        }

        [TestMethod]
        public void Should_reference_file_when_creating_a_link_with_a_file()
        {
            var textFile = new File("data.txt");
            var fileLink = new Link("linkData", textFile);

            Check.That(fileLink.Reference).IsEqualTo(textFile);
        }

        [TestMethod]
        public void Should_reference_folder_when_creating_a_link_with_a_folder()
        {
            var dataFolder = new Folder("data");
            var fileLink = new Link("linkData", dataFolder);

            Check.That(fileLink.Reference).IsEqualTo(dataFolder);
        }

        [TestMethod]
        public void Should_Write_element_name_when_calling_NameWriter()
        {
            IElement folder = CreateFolderTree();
            var writer = new NameWriter();
            Check.ThatCode(() => writer.Write(folder))
                .DoesNotThrow();
        }
    }
}
