using FilesLib.Models;
using FilesLib.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilesLib.Controllers
{
    public class FileController : IFileController
    {
        private readonly IFileVisitor<string> _showFileMetaData;

        public FileController(IFileVisitor<string> showFileMetaData)
        {
            if (showFileMetaData == null)
            {
                throw new ArgumentNullException(nameof(showFileMetaData));
            }

            _showFileMetaData = showFileMetaData;
        }

        public IList<string> ShowFileMetaData(IEnumerable<FileBase> files)
        {
            return files.Select(file => file.Accept(_showFileMetaData)).ToList();
        }
    }
}