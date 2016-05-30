using FilesLib.Wrappers;
using Shell32;

namespace FilesLibTests.TestObjects
{
    public static class TestFactory
    {
        public static IFilesAndFolders CreateFilesAndFolders()
        {
            return new FilesAndFolders(new DirectoryInfoFactory(), new Shell());
        }
    }
}