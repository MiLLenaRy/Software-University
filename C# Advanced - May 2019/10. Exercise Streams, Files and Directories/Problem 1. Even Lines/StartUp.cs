using System;using System.Collections.Generic;using System.IO;using System.Linq;using System.Text;using System.Text.RegularExpressions;

namespace Problem_1._Even_Lines
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string folder = "Files";
            string input = "text.txt";
            string pathToText = Path.Combine(folder, input);

            using (var reader = new StreamReader(pathToText))
            {
                string line;
                int counter = 0;

                List<string> resoult = new List<string>();

                while ((line = reader.ReadLine()) != null)
                {
                    counter++;
                    if (counter % 2 != 0)
                    {
                        string newText = string.Empty;
                        for (int i = 0; i < line.Length; i++)
                        {
                            char[] mustChange = new char[] { '-', ',', '.', '!', '?' };

                            if (mustChange.Contains(line[i]))
                            {
                                newText += '@';
                            }
                            else
                            {
                                newText += line[i];
                            }
                        }
                        resoult = newText.Split().Reverse().ToList();
                        Console.WriteLine(string.Join(' ', resoult));
                        resoult.Clear();
                    }

                }
            }

        }
    }
}

