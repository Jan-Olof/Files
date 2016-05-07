using FilesLib.Visitors;

namespace FilesLib.Models
{
    public class FileBase : IFile
    {
        public string Name { get; set; }

        public virtual string Accept(IFileVisitor fileVisitor)
        {
            return null;
        }
    }
}