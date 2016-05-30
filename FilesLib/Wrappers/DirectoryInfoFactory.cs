using System.IO;

namespace FilesLib.Wrappers
{
    public class DirectoryInfoFactory : IDirectoryInfoFactory
    {
        public IDirectoryInfo CreateDirectoryInfo(string path)
        {
            var dirInfo = new DirectoryInfo(path);
            var wrapper = new DirectoryInfoWrapper(dirInfo);
            return wrapper;
        }
    }
}