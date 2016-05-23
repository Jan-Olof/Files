using FilesLib.Visitors;

namespace FilesLib.Models
{
    public abstract class FileBase : IFile
    {
        public string Name { get; set; }

        public abstract T Accept<T>(IFileVisitor<T> fileVisitor);
    }
}