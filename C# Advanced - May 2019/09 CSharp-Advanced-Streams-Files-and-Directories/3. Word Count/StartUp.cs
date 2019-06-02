using System;using System.Collections.Generic;using System.IO;using System.Linq;using System.Text;using System.Text.RegularExpressions;

namespace _3._Word_Count
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string folder = "files";
            string wordsText = "words.txt";
            string inputText = "input.txt";
            string resoults = "output.txt";

            string wordsPath = Path.Combine(folder, wordsText);
            string textPath = Path.Combine(folder, inputText);
            string output = Path.Combine(folder, resoults);

            var dict = new Dictionary<string, int>();

            using (var wordsReader = new StreamReader(wordsPath))
            {
                string[] allWords = wordsReader.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (var word in allWords)
                {
                    using (var textReader = new StreamReader(textPath))
                    {
                        var line = textReader.ReadLine();

                        while (line != null)
                        {
                            Regex regex = new Regex(@"([A-Za-z'…])+");
                            var afterDecoding = regex.Matches(line);
                            foreach (var item in afterDecoding)
                            {
                                string castWord = item.ToString().ToLower();
                                if (castWord == word)
                                {
                                    if (!dict.ContainsKey(word))
                                    {
                                        dict.Add(word, 0);
                                    }
                                    dict[word]++;
                                }
                            }
                            line = textReader.ReadLine();
                        }


                    }
                }

                using (var writeLine = new StreamWriter(output))
                {
                    foreach (var word in dict.OrderByDescending(x => x.Value))
                    {
                        writeLine.WriteLine(word.Key + " - " + word.Value);
                        Console.WriteLine(word.Key + " - " + word.Value);
                    }
                }


            }
        }
    }
}
