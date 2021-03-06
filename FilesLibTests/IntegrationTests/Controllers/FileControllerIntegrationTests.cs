﻿using FilesLib.Controllers;
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
    public class FileControllerIntegrationTests
    {
        [TestInitialize]
        public void SetUp()
        {
        }

        /// <summary>
        /// The tear down.
        /// </summary>
        [TestCleanup]
        public void TearDown()
        {
        }

        [TestMethod]
        public void TestShouldShowFileMetaData()
        {
            // Arrange
            var fileList = CreateFileList();

            var sut = new FileController(new ShowFileMetaData(), TestFactory.CreateFilesAndFolders());

            // Act
            var result = sut.ShowFileMetaData(fileList);

            // Assert
            Assert.AreEqual("Name: A Few Notes On The Culture.doc, Pages: 1", result[0]);
            Assert.AreEqual("Name: 2001: A Space Odyssey, Length: 149", result[1]);
        }

        //[TestMethod]
        //public void TestShouldGetFiles()
        //{
        //    // Arrange
        //    var sut = this.CreateFileController();

        //    // Act
        //    var result = sut.GetFiles("C:\\folder");

        //    // Assert
        //    Assert.AreEqual("Name: A Few Notes On The Culture.doc, Pages: 1", result[0]);
        //    Assert.AreEqual("Name: 2001: A Space Odyssey, Length: 149", result[1]);
        //}

        private static IList<FileBase> CreateFileList()
        {
            return new List<FileBase>
            {
                SampleTextFiles.CreateTextFile(),
                SampleMovieFiles.CreateMovieFile()
            };
        }
    }
}