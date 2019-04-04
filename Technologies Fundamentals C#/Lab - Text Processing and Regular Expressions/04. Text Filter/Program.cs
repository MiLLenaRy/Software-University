using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToRemove = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            for (int a = 0; a < wordsToRemove.Length; a++)
            {
                string asterisks = new string('*', wordsToRemove[a].Length);

                // string asterisks = string.Empty;
                // for (int b = 0; b < wordsToRemove[a].Length; b++)
                // {
                //     asterisks += '*';
                // }

                while (text.Contains(wordsToRemove[a]))
                {

                    text = text.Replace(wordsToRemove[a], asterisks);
                }
            }
            Console.WriteLine(text);
        }
    }
}
