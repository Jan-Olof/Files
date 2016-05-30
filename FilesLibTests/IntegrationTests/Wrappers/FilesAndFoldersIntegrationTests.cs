using FilesLibTests.TestObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace FilesLibTests.IntegrationTests.Wrappers
{
    [TestClass]
    public class FilesAndFoldersIntegrationTests
    {
        [TestMethod]
        public void TestShouldGetDirectoryInfo()
        {
            // Arrange
            var sut = TestFactory.CreateFilesAndFolders();

            // Act
            var result = sut.GetDirectoryInfo(@"D:\Wallpapers");

            // Assert
            Assert.AreEqual(2, result.ToList().Count);
        }

        [TestMethod]
        public void TestShouldGetFileInfo()
        {
            // Arrange
            var sut = TestFactory.CreateFilesAndFolders();

            // Act
            var result = sut.GetFileInfo(@"D:\Wallpapers\More Wallpapers");

            // Assert
            Assert.AreEqual(123, result.ToList().Count);
        }

        [TestMethod]
        public void TestShouldGetFilesWithProperties()
        {
            // Arrange
            var sut = TestFactory.CreateFilesAndFolders();

            // Act
            var result = sut.GetFilesWithProperties(@"D:\Wallpapers\More Wallpapers");

            // Assert
            Assert.AreEqual(123, result.Count);
        }
    }
}