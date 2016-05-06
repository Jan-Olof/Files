using FilesLib.FileModels;
using FilesLib.Models;

namespace FilesLib.Visitors
{
    public interface IFileVisitor
    {
        void Visit(ImageFile imageFile);

        void Visit(MovieFile movieFile);
    }
}