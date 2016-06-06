using System.Collections.Generic;
using System.IO;

namespace FilesLibTests.TestObjects
{
    public static class SampleFileInfo
    {
        public static List<FileInfo> CreateFileInfos()
        {
            return new List<FileInfo>
            {
                new FileInfo(@"D:\Wallpapers\More Wallpapers\file1.txt"),
                new FileInfo(@"D:\Wallpapers\More Wallpapers\file2.jpg")
            };
        }
    }
}