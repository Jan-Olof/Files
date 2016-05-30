using System.Collections.Generic;
using System.IO;

namespace FilesLib.Wrappers
{
    public interface IDirectoryInfo
    {
        IEnumerable<DirectoryInfo> EnumerateDirectories();

        IEnumerable<FileInfo> EnumerateFiles();
    }
}