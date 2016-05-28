using FilesLib.DataTransferObjects;
using FilesLib.Factories;
using FilesLib.Models.FileProperties;
using FilesLib.Visitors;
using Shell32;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace FilesLib.Wrappers
{
    public class FilesAndFolders : IFilesAndFolders
    {
        public void GetDetailedFileProperties(string folder)
        {
            var shell = new Shell();

            var objFolder = shell.NameSpace(folder);

            var arrHeaders = GetArrHeaders(objFolder);

            foreach (FolderItem2 item in objFolder.Items())
            {
                GetFileDetails(arrHeaders, objFolder, item);
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

        private static IList<string> GetArrHeaders(Folder objFolder) // TODO: What to do with this? Class that maps to one property class? (Directory?)
        {
            IList<string> arrHeaders = new List<string>();

            IList<IFileProperty> fileProperties = new List<IFileProperty>();

            for (int i = 0; i < short.MaxValue; i++)
            {
                string header = objFolder.GetDetailsOf(null, i);

                if (string.IsNullOrEmpty(header))
                {
                    break;
                }

                fileProperties.Add(FilePropertyFactory.CreateFileProperty(i, header));

                arrHeaders.Add(header);
            }

            return arrHeaders;
        }

        private FileDetails GetFileDetails(IList<string> arrHeaders, Folder objFolder, FolderItem2 item)
        {
            var fileDetails = new FileDetails();

            for (int i = 0; i < arrHeaders.Count; i++)
            {
                Debug.Print($"{i}\t{arrHeaders[i]}: {objFolder.GetDetailsOf(item, i)}");

                string propertyValue = objFolder.GetDetailsOf(item, i);

                switch (i)
                {
                    case 0:
                        fileDetails.Name = propertyValue;
                        break;

                    case 1:
                        fileDetails.Size = propertyValue;
                        break;

                    case 2:
                        fileDetails.ItemType = propertyValue;
                        break;
                }
            }

            return fileDetails;
        }
    }
}