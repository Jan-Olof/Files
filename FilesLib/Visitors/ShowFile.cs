using FilesLib.FileModels;
using FilesLib.Models;

namespace FilesLib.Visitors
{
    public class ShowFile : IFileVisitor
    {
        public void Visit(ImageFile imageFile)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(MovieFile movieFile)
        {
            throw new System.NotImplementedException();
        }
    }
}