using FilesLib.Models;
using FilesLib.Visitors;
using System.Collections.Generic;

namespace FilesLib.Controllers
{
    public class FileController : IFileController
    {
        public IList<string> ShowFileMetaData()
        {
            IList<string> metaData = new List<string>();

            var showFileMetaData = new ShowFileMetaData();

            var files = new List<FileBase>();

            foreach (var file in files)
            {
                metaData.Add(file.Accept(showFileMetaData));
            }

            return metaData;
        }
    }
}