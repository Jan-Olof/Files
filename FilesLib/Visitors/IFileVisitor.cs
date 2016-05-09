using FilesLib.Models;

namespace FilesLib.Visitors
{
    public interface IFileVisitor<out T>
    {
        T Visit(TextFile textFile);

        T Visit(MovieFile movieFile);
    }
}