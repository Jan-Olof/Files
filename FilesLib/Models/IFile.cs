using FilesLib.Models.FileProperties;
using FilesLib.Visitors;
using System.Collections.Generic;

namespace FilesLib.Models
{
    public interface IFile
    {
        string Name { get; set; }

        IList<IFileProperty> Properties { get; set; }

        T Accept<T>(IFileVisitor<T> fileVisitor);
    }
}