using System;using System.Collections.Generic;using System.IO;using System.Linq;using System.Text;using System.Text.RegularExpressions;

namespace Problem_3._Word_Count
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string folder = "Files";
            string text = "text.txt";
            string words = "words.txt";
            string expectedResult = "expectedResult.txt";
            string finalResult = "actualResult.txt";

            string pathToText = Path.Combine(folder, text);
            string pathToWords = Path.Combine(folder, words);
            string pathToExpResult = Path.Combine(folder, expectedResult);
            string pathToResult = Path.Combine(folder, finalResult);

            string[] allText = File.ReadAllLines(pathToText);
            string[] allWords = File.ReadAllLines(pathToWords);

            var result = new Dictionary<string, int>();

            foreach (var word in allWords)
            {
                foreach (var item in allText)
                {
                    ConvectorToLetters(item);
                    string newLine = ConvectorToLetters(item);

                    string[] byWords = newLine.Split().ToArray();
                    for (int i = 0; i < byWords.Length; i++)
                    {
                        if (byWords[i].ToLower() == word)
                        {
                             if (!result.ContainsKey(word))
                             {
                                 result.Add(word, 0);
                             }
                             result[word]++;
                        }
                    }
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
                File.AppendAllText(pathToResult, $"{item.Key} - {item.Value}{Environment.NewLine}");
            }
            foreach (var item in result.OrderByDescending(x=>x.Value))
            {
                File.AppendAllText(pathToExpResult, $"{item.Key} - {item.Value}{Environment.NewLine}");
            }

        }

        private static string ConvectorToLetters(string item)
        {
            string newLine = string.Empty;
            foreach (var letter in item)
            {
                if (char.IsLetter(letter)||letter==' ')
                {
                    newLine += letter;
                }
            }
            return newLine;
        }
    }
}
