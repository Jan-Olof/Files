using FilesLib.Models;
using FilesLib.Visitors;
using FilesLib.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilesLib.Controllers
{
    using FilesLib.DataTransferObjects;

    public class FileController : IFileController
    {
        private readonly IFilesAndFolders _filesAndFolders;
        private readonly IFileVisitor<string> _showFileMetaData;

        public FileController(IFileVisitor<string> showFileMetaData, IFilesAndFolders filesAndFolders)
        {
            if (showFileMetaData == null)
            {
                throw new ArgumentNullException(nameof(showFileMetaData));
            }

            if (filesAndFolders == null)
            {
                throw new ArgumentNullException(nameof(filesAndFolders));
            }

            _showFileMetaData = showFileMetaData;
            _filesAndFolders = filesAndFolders;
        }

        public IList<FileDto> GetFiles(string folder)
        {
            return this._filesAndFolders.GetFilesWithProperties(folder);
        }

        public IList<string> ShowFileMetaData(IEnumerable<FileBase> files)
        {
            return files.Select(file => file.Accept(_showFileMetaData)).ToList();
        }
    }
}