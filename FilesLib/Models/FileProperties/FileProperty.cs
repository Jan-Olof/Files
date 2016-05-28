namespace FilesLib.Models.FileProperties
{
    public abstract class FileProperty : IFileProperty
    {
        protected FileProperty()
        {
            Name = string.Empty;
        }

        protected FileProperty(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}