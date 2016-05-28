using FilesLib.Models.FileProperties;
using System.Collections.Generic;

namespace FilesLib.DataTransferObjects
{
    public class FileDto
    {
        public FileDto()
        {
            Properties = new List<IFileProperty>();
        }

        public FileDto(IList<IFileProperty> properties)
        {
            Properties = properties;
        }

        public IList<IFileProperty> Properties { get; set; }
    }
}