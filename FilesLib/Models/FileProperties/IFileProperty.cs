namespace FilesLib.Models.FileProperties
{
    public interface IFileProperty
    {
        int Id { get; set; }
        string Name { get; set; }

        string Value { get; set; }
    }
}