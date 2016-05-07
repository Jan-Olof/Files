using FilesLib.Visitors;

namespace FilesLib.Models
{
    public class TextFile : FileBase
    {
        public int Pages { get; set; }

        public override string Accept(IFileVisitor fileVisitor)
        {
            return fileVisitor.Visit(this);
        }
    }
}