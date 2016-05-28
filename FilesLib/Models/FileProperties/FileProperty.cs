namespace FilesLib.Models.FileProperties
{
    public abstract class FileProperty : IFileProperty
    {
        protected FileProperty()
        {
            Name = string.Empty;
            Value = string.Empty;
        }

        protected FileProperty(int id, string name)
        {
            Id = id;
            Name = name;
            Value = string.Empty;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Value { get; set; }
    }
}