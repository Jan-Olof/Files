using FilesLib.Wrappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Shell32;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FilesLibTests.UnitTests.Wrappers
{
    [TestClass]
    public class FilesAndFoldersTests
    {
        private IDirectoryInfoFactory _directoryInfoFactory;

        private Shell _shell;

        /// <summary>
        /// The set up.
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            _directoryInfoFactory = Substitute.For<IDirectoryInfoFactory>();
            _shell = Substitute.For<Shell>();
        }

        /// <summary>
        /// The tear down.
        /// </summary>
        [TestCleanup]
        public void TearDown()
        {
        }

        [TestMethod]
        public void TestShouldGetDirectoryInfo()
        {
            // Arrange
            _directoryInfoFactory.CreateDirectoryInfo(@"D:\Wallpapers").EnumerateDirectories().Returns(new List<DirectoryInfo> { new DirectoryInfo(@"D:\Wallpapers"), new DirectoryInfo(@"D:\Wallpapers") });

            var sut = CreateFilesAndFolders();

            // Act
            var result = sut.GetDirectoryInfo(@"D:\Wallpapers");

            // Assert
            Assert.AreEqual(2, result.ToList().Count);
        }

        [TestMethod]
        public void TestShouldGetFileInfo()
        {
            // Arrange
            _directoryInfoFactory.CreateDirectoryInfo(@"D:\Wallpapers\More Wallpapers").EnumerateFiles().Returns(new List<FileInfo> { new FileInfo(@"D:\Wallpapers\More Wallpapers"), new FileInfo(@"D:\Wallpapers\More Wallpapers") });

            var sut = CreateFilesAndFolders();

            // Act
            var result = sut.GetFileInfo(@"D:\Wallpapers\More Wallpapers");

            // Assert
            Assert.AreEqual(2, result.ToList().Count);
        }

        [TestMethod]
        public void TestShouldGetFilesWithProperties()
        {
            // Arrange
            var sut = CreateFilesAndFolders();

            // Act
            var result = sut.GetFilesWithProperties(@"D:\Wallpapers\More Wallpapers");

            // Assert
            Assert.AreEqual(123, result.Count);
        }

        private IFilesAndFolders CreateFilesAndFolders()
        {
            return new FilesAndFolders(_directoryInfoFactory, _shell);
        }
    }
}