using FilesLib.Wrappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace FilesLibTests.IntegrationTests.WrappersTests
{
    [TestClass]
    public class FilesAndFoldersTests
    {
        [TestMethod]
        public void TestShouldGetDirectoryInfo()
        {
            // Arrange
            var sut = new FilesAndFolders();

            // Act
            var result = sut.GetDirectoryInfo(@"D:\Wallpapers");

            // Assert
            Assert.AreEqual(2, result.ToList().Count);
        }

        [TestMethod]
        public void TestShouldGetFileInfo()
        {
            // Arrange
            var sut = new FilesAndFolders();

            // Act
            var result = sut.GetFileInfo(@"D:\Wallpapers\More Wallpapers");

            // Assert
            Assert.AreEqual(123, result.ToList().Count);
        }
    }
}