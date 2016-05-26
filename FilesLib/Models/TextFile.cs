using FilesLib.Visitors;

namespace FilesLib.Models
{
    public class TextFile : FileBase
    {
        public TextFile()
        {
        }

        public int Pages { get; set; }

        public override T Accept<T>(IFileVisitor<T> fileVisitor)
        {
            return fileVisitor.Visit(this);
        }
    }
}