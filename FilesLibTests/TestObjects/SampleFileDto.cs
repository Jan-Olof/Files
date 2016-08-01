namespace FilesLibTests.TestObjects
{
    using FilesLib.DataTransferObjects;
    using FilesLib.Models.FileProperties;
    using System.Collections.Generic;

    public static class SampleFileDto
    {
        public static IList<FileDto> CreateFileDtos()
        {
            return new List<FileDto> { CreateFileDto1(), CreateFileDto2() };
        }

        private static FileDto CreateFileDto1()
        {
            return new FileDto { Properties = SampleFileProperties.CreateFileProperties1() };
        }

        private static FileDto CreateFileDto2()
        {
            return new FileDto { Properties = SampleFileProperties.CreateFileProperties2() };
        }
    }
}