using FilesLib.Visitors;

namespace FilesLib.Models
{
    public class MovieFile : FileBase
    {
        public decimal Length { get; set; }

        public override T Accept<T>(IFileVisitor<T> fileVisitor)
        {
            return fileVisitor.Visit(this);
        }
    }
}