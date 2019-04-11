using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            string artistName = @"[A-Z][a-z ']+";
            string songName = @"[A-Z ]+";


            while ((command = Console.ReadLine()) != "end")
            {
                string[] words = command.Split(':').ToArray();
                var stringArtist = new StringBuilder(words[0]);
                var stringSong = new StringBuilder(words[1]);

                Match name = Regex.Match(stringArtist.ToString(), artistName);
                Match song = Regex.Match(stringSong.ToString(), songName);

                string code = string.Empty;
                if (name.Length == stringArtist.Length && song.Length == stringSong.Length)
                {
                    int decript = stringArtist.Length;

                    for (int i = 0; i < stringArtist.Length; i++)
                    {
                        int number = 0;
                        if (stringArtist[i] == ' ')
                        {
                            code += (char)32;
                        }
                        else if (stringArtist[i] == (char)39)
                        {
                            code += (char)39;
                        }
                        else if ((stringArtist[i] + decript) <= 122)
                        {
                            code += (char)(stringArtist[i] + decript);
                        }
                        else
                        {
                            number = stringArtist[i] + decript - 122 + 96;
                            code += (char)number;
                        }
                    }
                    code += '@';
                    for (int i = 0; i < stringSong.Length; i++)
                    {
                        int number = 0;
                        if (stringSong[i] == ' ')
                        {
                            code += (char)32;
                        }
                        else if (stringSong[i] == (char)39)
                        {
                            code += (char)96;
                        }
                        else if ((stringSong[i] + decript) <= 90)
                        {
                            code += (char)(stringSong[i] + decript);
                        }
                        else
                        {
                            number = stringSong[i] + decript - 90 + 64;
                            code += (char)number;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                if (name.Length == stringArtist.Length && song.Length == stringSong.Length)
                {
                    Console.WriteLine($"Successful encryption: {string.Join(' ', code)}");
                }
                
            }
        }
    }
}
