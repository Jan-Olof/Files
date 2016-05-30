using System.Collections.Generic;
using System.IO;

namespace FilesLib.Wrappers
{
    public class DirectoryInfoWrapper : IDirectoryInfo
    {
        private readonly DirectoryInfo _directoryInfo;

        public DirectoryInfoWrapper(DirectoryInfo directoryInfo)
        {
            _directoryInfo = directoryInfo;
        }

        public IEnumerable<DirectoryInfo> EnumerateDirectories()
        {
            return _directoryInfo.EnumerateDirectories();
        }

        public IEnumerable<FileInfo> EnumerateFiles()
        {
            return _directoryInfo.EnumerateFiles();
        }
    }
}