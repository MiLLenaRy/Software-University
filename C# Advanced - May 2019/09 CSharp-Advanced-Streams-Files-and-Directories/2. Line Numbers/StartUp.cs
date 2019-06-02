using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Line_Numbers
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            string folder = "files";
            string readName = "input.txt";
            string writeFile = "output.txt";

            string filePath = Path.Combine(folder, readName);
            string writePath = Path.Combine(folder, writeFile);

            using (var reader = new StreamReader(filePath))
            {

                int count = 0;
                string line = reader.ReadLine();
                using (var writer = new StreamWriter(writePath))
                {
                    while (line != null)
                    {
                        count++;
                        Console.WriteLine($"{count}. {line}");
                        writer.WriteLine($"{count}. {line}");

                        line = reader.ReadLine();
                    }
                }
            }

        }
    }
}


