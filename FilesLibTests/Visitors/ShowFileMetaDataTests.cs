using FilesLib.Visitors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static FilesLibTests.TestObject.SampleMovieFiles;
using static FilesLibTests.TestObject.SampleTextFiles;

namespace FilesLibTests.Visitors
{
    [TestClass]
    public class ShowFileMetaDataTests
    {
        [TestMethod]
        public void TestShouldVisitMovieFile()
        {
            // Arrange
            var sut = new ShowFileMetaData();

            // Act
            string result = sut.Visit(CreateMovieFile());

            // Assert
            Assert.AreEqual("Name: 2001: A Space Odyssey, Length: 149", result);
        }

        [TestMethod]
        public void TestShouldVisitTextFile()
        {
            // Arrange
            var sut = new ShowFileMetaData();

            // Act
            string result = sut.Visit(CreateTextFile());

            // Assert
            Assert.AreEqual("Name: A Few Notes On The Culture.doc, Pages: 1", result);
        }
    }
}