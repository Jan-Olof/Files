﻿using FilesLib.Visitors;

namespace FilesLib.Models
{
    public class MovieFile : FileBase
    {
        public decimal Length { get; set; }

        public override string Accept(IFileVisitor fileVisitor)
        {
            return fileVisitor.Visit(this);
        }
    }
}