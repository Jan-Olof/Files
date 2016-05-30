namespace FilesLib.Wrappers
{
    public interface IDirectoryInfoFactory
    {
        IDirectoryInfo CreateDirectoryInfo(string path);
    }
}