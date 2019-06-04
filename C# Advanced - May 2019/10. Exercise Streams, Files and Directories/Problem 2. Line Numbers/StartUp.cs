using System;using System.Collections.Generic;using System.IO;using System.Linq;using System.Text;using System.Text.RegularExpressions;

namespace Problem_2._Line_Numbers
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string folder = "Files";
            string text = "text.txt";
            string output = "output.txt";         

            var textPath = Path.Combine(folder, text);
            var outputPath = Path.Combine(folder, output);

            string[] textLines = File.ReadAllLines(textPath);
            int rowsCount = 0;

            foreach (var currentLine in textLines)
            {
                rowsCount++;
                int lattersCounter = currentLine.Count(char.IsLetter);
                int punctsCounter = currentLine.Count(char.IsPunctuation);


                File.AppendAllText(outputPath, $"Line {rowsCount}:" +
                    $" {currentLine}({lattersCounter})({punctsCounter})" +
                    $"{Environment.NewLine}");
            }          
        }
    }
}
