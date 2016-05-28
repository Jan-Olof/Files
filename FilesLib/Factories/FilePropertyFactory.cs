using FilesLib.Models.FileProperties;
using System;

namespace FilesLib.Factories
{
    public class FilePropertyFactory
    {
        public static IFileProperty CreateFileProperty(int propertyId, string propertyName)
        {
            switch (propertyName)
            {
                case "Name":
                    return new Name(propertyId, propertyName);

                case "Size":
                    return new Size(propertyId, propertyName);

                case "Item type":
                    return new ItemType(propertyId, propertyName);

                default:
                    throw new NotImplementedException();
            }
        }
    }
}