using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _1.OddLines
{
    public class Oddlines
    {
        public static void Main(string[] args)
        {
            // string filePath = "files" + Path.PathSeparator + "input.txt";
            string path = "files";
            string fileName = "input.txt";
            string filePath = Path.Combine(path, fileName);

            using (var reader = new StreamReader(filePath))
            {
                int count = 0;

                string line = reader.ReadLine();

                while (line != null)
                {
                    if (count % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    count++;
                    line = reader.ReadLine();
                }

            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
