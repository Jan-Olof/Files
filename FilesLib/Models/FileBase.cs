using FilesLib.Models.FileProperties;
using FilesLib.Visitors;
using System.Collections.Generic;

namespace FilesLib.Models
{
    public abstract class FileBase : IFile
    {
        protected FileBase()
        {
            Name = string.Empty;
        }

        public string Name { get; set; }
        public IList<IFileProperty> Properties { get; set; }

        public abstract T Accept<T>(IFileVisitor<T> fileVisitor);
    }
}