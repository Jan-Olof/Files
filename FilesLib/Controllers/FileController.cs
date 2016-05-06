using FilesLib.Models;
using FilesLib.Visitors;
using System.Collections.Generic;

namespace FilesLib.Controllers
{
    public class FileController : IFileController
    {
        public void ShowFiles()
        {
            var showFile = new ShowFile();

            var files = new List<FileBase>();

            foreach (var file in files)
            {
                file.Accept(showFile);
            }
        }
    }
}