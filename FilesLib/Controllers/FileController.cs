using FilesLib.Models;
using FilesLib.Visitors;
using FilesLib.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilesLib.Controllers
{
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

        public void GetFiles()
        {
            throw new NotImplementedException(); // TODO: Implement this somehow! (Use IFilesAndFolders)
        }

        public IList<string> ShowFileMetaData(IEnumerable<FileBase> files)
        {
            return files.Select(file => file.Accept(_showFileMetaData)).ToList();
        }
    }
}