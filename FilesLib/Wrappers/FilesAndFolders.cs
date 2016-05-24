using System.Collections.Generic;
using System.IO;

namespace FilesLib.Wrappers
{
    public class FilesAndFolders : IFilesAndFolders
    {
        public IEnumerable<DirectoryInfo> GetDirectoryInfo(string folder)
        {
            var dir = new DirectoryInfo(folder);

            return dir.EnumerateDirectories();
        }

        public IEnumerable<FileInfo> GetFileInfo(string folder)
        {
            var dir = new DirectoryInfo(folder);

            return dir.EnumerateFiles();
        }
    }
}