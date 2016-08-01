using FilesLib.Models;
using System.Collections.Generic;

namespace FilesLib.Controllers
{
    using FilesLib.DataTransferObjects;

    public interface IFileController
    {
        IList<FileDto> GetFiles(string folder);

        IList<string> ShowFileMetaData(IEnumerable<FileBase> files);
    }
}