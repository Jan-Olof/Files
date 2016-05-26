using FilesLib.Visitors;

namespace FilesLib.Models
{
    public abstract class FileBase : IFile
    {
        protected FileBase()
        {
            Name = string.Empty;
        }

        public string Name { get; set; }

        public abstract T Accept<T>(IFileVisitor<T> fileVisitor);
    }
}