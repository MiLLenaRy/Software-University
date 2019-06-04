using System;using System.Collections.Generic;using System.IO;using System.Linq;using System.Text;using System.Text.RegularExpressions;

namespace Problem_5._Directory_Traversal
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] fileNameArray = Directory.GetFiles(".", "*.*");


            var dirInfo = new Dictionary<string, Dictionary<string, double>>();
            var directoryInfo = new DirectoryInfo(".");
            var allFiles = directoryInfo.GetFiles();

            foreach (var currentFile in allFiles)
            {
                double size = currentFile.Length / 1024d;
                string fileName = currentFile.Name;
                string extension = currentFile.Extension;

                if (!dirInfo.ContainsKey(extension))
                {
                    dirInfo.Add(extension, new Dictionary<string, double>());
                }
                if (!dirInfo[extension].ContainsKey(fileName))
                {
                    dirInfo[extension].Add(fileName, size);
                }
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";

            var sortedDict = dirInfo
               .OrderByDescending(x => x.Value.Count)
               .ThenBy(x => x.Key)
               .ToDictionary(x => x.Key, y => y.Value);

            foreach (var (extension, value) in sortedDict)
            {
                File.AppendAllText(path,extension);
                foreach (var (fileName, size) in value.OrderBy(x => x.Value))
                {
                    File.AppendAllText(path,$"--{fileName} - {Math.Round(size, 3)}kb" +
                        $"{Environment.NewLine}");
                }
            }


        }
    }
}
