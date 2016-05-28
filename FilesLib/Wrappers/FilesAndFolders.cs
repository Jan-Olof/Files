using FilesLib.DataTransferObjects;
using FilesLib.Factories;
using FilesLib.Models.FileProperties;
using NLog;
using Shell32;
using System;
using System.Collections.Generic;
using System.IO;

namespace FilesLib.Wrappers
{
    public class FilesAndFolders : IFilesAndFolders
    {
        /// <summary>
        /// This is from NLog and is used for logging.
        /// </summary>
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public IEnumerable<DirectoryInfo> GetDirectoryInfo(string folder)
        {
            try
            {
                var dir = new DirectoryInfo(folder);

                return dir.EnumerateDirectories();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw;
            }
        }

        public IEnumerable<FileInfo> GetFileInfo(string folder)
        {
            try
            {
                var dir = new DirectoryInfo(folder);

                return dir.EnumerateFiles();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw;
            }
        }

        public IList<FileDto> GetFilesWithProperties(string folder)
        {
            IList<FileDto> fileDtos = new List<FileDto>();

            try
            {
                var shell = new Shell(); // TODO: Create wrapper

                var objFolder = shell.NameSpace(folder);

                var fileProperties = GetAvailableFileProperties(objFolder);

                foreach (FolderItem2 item in objFolder.Items())
                {
                    fileDtos.Add(new FileDto(GetFilePropertyDetails(fileProperties, objFolder, item)));
                }

                return fileDtos;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw;
            }
        }

        private static void AddFileProperty(IList<IFileProperty> fileProperties, int i, string header)
        {
            try
            {
                fileProperties.Add(FilePropertyFactory.CreateFileProperty(i, header));
            }
            catch (NotImplementedException ex)
            {
                Logger.Error(ex);
            }
        }

        private static IList<IFileProperty> GetAvailableFileProperties(Folder objFolder)
        {
            IList<IFileProperty> fileProperties = new List<IFileProperty>();

            for (int i = 0; i < short.MaxValue; i++)
            {
                string header = objFolder.GetDetailsOf(null, i);

                if (string.IsNullOrEmpty(header))
                {
                    break;
                }

                AddFileProperty(fileProperties, i, header);
            }

            return fileProperties;
        }

        private static IList<IFileProperty> GetFilePropertyDetails(IList<IFileProperty> fileProperties, Folder objFolder, FolderItem2 item)
        {
            foreach (var fileProperty in fileProperties)
            {
                fileProperty.Value = objFolder.GetDetailsOf(item, fileProperty.Id);
            }

            return fileProperties;
        }
    }
}