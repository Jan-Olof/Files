using Shell32;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace FilesLib.Wrappers
{
    public class FilesAndFolders : IFilesAndFolders
    {
        public static void GetDetailedFileProperties(string folder)
        {
            var arrHeaders = new List<string>();

            var shell = new Shell();

            var objFolder = shell.NameSpace(folder);

            for (int i = 0; i < short.MaxValue; i++)
            {
                string header = objFolder.GetDetailsOf(null, i);
                if (string.IsNullOrEmpty(header))
                    break;
                arrHeaders.Add(header);
            }

            foreach (FolderItem2 item in objFolder.Items())
            {
                for (int i = 0; i < arrHeaders.Count; i++)
                {
                    Debug.Print($"{i}\t{arrHeaders[i]}: {objFolder.GetDetailsOf(item, i)}");
                }
            }
        }

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