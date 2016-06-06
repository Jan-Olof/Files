using System.Collections.Generic;
using System.IO;

namespace FilesLibTests.TestObjects
{
    public static class SampleDirectoryInfo
    {
        public static IList<DirectoryInfo> CreateDirectoryInfos()
        {
            return new List<DirectoryInfo>
            {
                new DirectoryInfo(@"D:\Wallpapers\More Wallpapers"),
                new DirectoryInfo(@"D:\Wallpapers\Nice Wallpaper")
            };
        }
    }
}