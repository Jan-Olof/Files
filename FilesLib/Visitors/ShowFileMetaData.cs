using FilesLib.Models;

namespace FilesLib.Visitors
{
    public class ShowFileMetaData : IFileVisitor<string>
    {
        public string Visit(TextFile textFile)
        {
            return $"Name: {textFile.Name}, Pages: {textFile.Pages}";
        }

        public string Visit(MovieFile movieFile)
        {
            return $"Name: {movieFile.Name}, Length: {movieFile.Length}";
        }
    }
}