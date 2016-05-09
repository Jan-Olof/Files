using FilesLib.Visitors;
using System;

namespace FilesLib.Models
{
    public class FileBase : IFile
    {
        public string Name { get; set; }

        public virtual T Accept<T>(IFileVisitor<T> fileVisitor)
        {
            throw new NotImplementedException("Accept not implemented in FileBase.");
        }
    }
}