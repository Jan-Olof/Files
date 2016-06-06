using FilesLib.Models;
using System.Collections.Generic;

namespace FilesLib.Controllers
{
    public interface IFileController
    {
        void GetFiles();

        IList<string> ShowFileMetaData(IEnumerable<FileBase> files);
    }
}