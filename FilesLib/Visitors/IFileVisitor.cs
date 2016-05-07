using FilesLib.Models;

namespace FilesLib.Visitors
{
    public interface IFileVisitor
    {
        string Visit(TextFile textFile);

        string Visit(MovieFile movieFile);
    }
}