namespace FilesLibTests.TestObjects
{
    using FilesLib.Models.FileProperties;
    using FilesLib.Models.FileProperties.SubClasses;
    using System.Collections.Generic;

    public static class SampleFileProperties
    {
        public static IList<IFileProperty> CreateFileProperties1()
        {
            return new List<IFileProperty> { CreateFilePropertyName1() };
        }

        public static IList<IFileProperty> CreateFileProperties2()
        {
            return new List<IFileProperty> { CreateFilePropertyName2() };
        }

        private static IFileProperty CreateFilePropertyName1()
        {
            return new Name { Id = 1, Name = "Name", Value = "file1.txt" };
        }

        private static IFileProperty CreateFilePropertyName2()
        {
            return new Name { Id = 1, Name = "Name", Value = "file2.jpg" };
        }
    }
}