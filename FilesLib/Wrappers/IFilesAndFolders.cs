using System.Collections.Generic;
using System.IO;

namespace FilesLib.Wrappers
{
    public interface IFilesAndFolders
    {
        IEnumerable<DirectoryInfo> GetDirectoryInfo(string folder);

        IEnumerable<FileInfo> GetFileInfo(string folder);
    }
}