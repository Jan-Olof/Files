using FilesLib.Visitors;

namespace FilesLib.Models
{
    public class ImageFile : FileBase
    {
        public override void Accept(IFileVisitor fileVisitor)
        {
            fileVisitor.Visit(this);
        }
    }
}