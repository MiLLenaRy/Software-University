﻿using System;
using System.Linq;

namespace Problem_6._Zip_and_Extract
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var zipFile = @"..\..\..\myZip.zip";
            var file = "copyMe.png";

            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(file, Path.GetFileName(file));
            }
        }
    }
}