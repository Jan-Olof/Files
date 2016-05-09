using FilesLib.Visitors;
using FilesLibTests.TestObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilesLibTests.Unit_tests.Visitors
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
            string result = sut.Visit(SampleMovieFiles.CreateMovieFile());

            // Assert
            Assert.AreEqual("Name: 2001: A Space Odyssey, Length: 149", result);
        }

        [TestMethod]
        public void TestShouldVisitTextFile()
        {
            // Arrange
            var sut = new ShowFileMetaData();

            // Act
            string result = sut.Visit(SampleTextFiles.CreateTextFile());

            // Assert
            Assert.AreEqual("Name: A Few Notes On The Culture.doc, Pages: 1", result);
        }
    }
}