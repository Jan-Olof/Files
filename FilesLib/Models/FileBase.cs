using FilesLib.FileModels;
using FilesLib.Visitors;

namespace FilesLib.Models
{
    public class FileBase : IFile
    {
        public string Name { get; set; }

        public virtual void Accept(IFileVisitor fileVisitor)
        {
        }
    }
}