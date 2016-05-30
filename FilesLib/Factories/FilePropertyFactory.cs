using FilesLib.Models.FileProperties;
using FilesLib.Models.FileProperties.SubClasses;
using System;

namespace FilesLib.Factories
{
    public static class FilePropertyFactory
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

                case "Date modified":
                    return new DateModified(propertyId, propertyName);

                case "Date created":
                    return new DateCreated(propertyId, propertyName);

                case "Date accessed":
                    return new DateAccessed(propertyId, propertyName);

                case "Length":
                    return new Length(propertyId, propertyName);

                case "Dimensions":
                    return new Dimensions(propertyId, propertyName);

                default:
                    throw new NotImplementedException($"Property name {propertyName} is not implemented in FilePropertyFactory.");
            }
        }
    }
}