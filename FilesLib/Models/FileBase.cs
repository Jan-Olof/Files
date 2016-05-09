using FilesLib.Visitors;
using System;

namespace FilesLib.Models
{
    public class FileBase : IFile
    {
        public string Name { get; set; }

        public virtual string Accept(IFileVisitor fileVisitor)
        {
            throw new NotImplementedException("Accept not implemented in FileBase.");
        }
    }
}