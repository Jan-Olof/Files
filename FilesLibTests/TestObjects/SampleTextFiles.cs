﻿using FilesLib.Models;

namespace FilesLibTests.TestObjects
{
    public static class SampleTextFiles
    {
        public static TextFile CreateTextFile()
        {
            return new TextFile
            {
                Name = "A Few Notes On The Culture.doc",
                Pages = 1
            };
        }
    }
}