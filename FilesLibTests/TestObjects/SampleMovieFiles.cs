using FilesLib.Models;

namespace FilesLibTests.TestObjects
{
    public static class SampleMovieFiles
    {
        public static MovieFile CreateMovieFile()
        {
            return new MovieFile
            {
                Name = "2001: A Space Odyssey",
                Length = 149
            };
        }
    }
}