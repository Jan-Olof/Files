using FilesLib.Models;
using System.Collections.Generic;

namespace FilesLib.Controllers
{
    public interface IFileController
    {
        IList<string> ShowFileMetaData(IEnumerable<FileBase> files);
    }
}