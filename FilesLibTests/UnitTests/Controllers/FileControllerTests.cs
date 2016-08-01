using FilesLib.Controllers;
using FilesLib.Models;
using FilesLib.Visitors;
using FilesLibTests.TestObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Collections.Generic;

namespace FilesLibTests.UnitTests.Controllers
{
    using FilesLib.Wrappers;

    [TestClass]
    public class FileControllerTests
    {
        private IFilesAndFolders filesAndFolders;

        private IFileVisitor<string> showFileMetaData;

        [TestInitialize]
        public void SetUp()
        {
            this.filesAndFolders = Substitute.For<IFilesAndFolders>();
            this.showFileMetaData = Substitute.For<IFileVisitor<string>>();
        }

        /// <summary>
        /// The tear down.
        /// </summary>
        [TestCleanup]
        public void TearDown()
        {
        }

        [TestMethod]
        public void TestShouldGetFiles()
        {
            // Arrange
            this.filesAndFolders.GetFilesWithProperties("C:\\folder").Returns(SampleFileDto.CreateFileDtos());

            var sut = this.CreateFileController();

            // Act
            var result = sut.GetFiles("C:\\folder");

            // Assert
            Assert.AreEqual("file1.txt", result[0].Properties[0].Value);
            Assert.AreEqual("file2.jpg", result[1].Properties[0].Value);
        }

        [TestMethod]
        public void TestShouldShowFileMetaData()
        {
            // Arrange
            var fileList = CreateFileList();

            var sut = this.CreateFileController();

            // Act
            var result = sut.ShowFileMetaData(fileList);

            // Assert
            Assert.AreEqual("", result[0]);
            Assert.AreEqual("", result[1]);
        }

        private static IList<FileBase> CreateFileList()
        {
            return new List<FileBase>
            {
                SampleTextFiles.CreateTextFile(),
                SampleMovieFiles.CreateMovieFile()
            };
        }

        private FileController CreateFileController()
        {
            return new FileController(this.showFileMetaData, this.filesAndFolders);
        }
    }
}