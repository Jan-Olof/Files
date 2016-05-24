using FilesLib.Controllers;
using FilesLib.Models;
using FilesLib.Visitors;
using FilesLibTests.TestObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FilesLibTests.UnitTests.Controllers
{
    [TestClass]
    public class FileControllerTests
    {
        [TestMethod]
        public void TestShouldShowFileMetaData()
        {
            // Arrange
            var fileList = CreateFileList();

            var sut = new FileController(new ShowFileMetaData());

            // Act
            var result = sut.ShowFileMetaData(fileList);

            // Assert
            Assert.AreEqual("Name: A Few Notes On The Culture.doc, Pages: 1", result[0]);
            Assert.AreEqual("Name: 2001: A Space Odyssey, Length: 149", result[1]);
        }

        private static List<FileBase> CreateFileList()
        {
            return new List<FileBase>
            {
                SampleTextFiles.CreateTextFile(),
                SampleMovieFiles.CreateMovieFile()
            };
        }
    }
}