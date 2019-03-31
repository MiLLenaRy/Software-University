using System;

namespace _05_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int characters = int.Parse(Console.ReadLine());

            string message = string.Empty;
            for (int a = 1; a <= characters; a++)
            {
                string numberToChar = Console.ReadLine();
                if (numberToChar == "1")
                {

                }
                else if (numberToChar.Contains("2"))
                {
                    int count = numberToChar.Length;
                    if (count == 1)
                    {
                        numberToChar = "a";
                    }
                    else if (count == 2)
                    {
                        numberToChar = "b";
                    }
                    else
                    {
                        numberToChar = "c";
                    }
                }
                else if (numberToChar.Contains("3"))
                {
                    int count = numberToChar.Length;
                    if (count == 1)
                    {
                        numberToChar = "d";
                    }
                    else if (count == 2)
                    {
                        numberToChar = "e";
                    }
                    else
                    {
                        numberToChar = "f";
                    }
                }
                else if (numberToChar.Contains("4"))
                {
                    int count = numberToChar.Length;
                    if (count == 1)
                    {
                        numberToChar = "g";
                    }
                    else if (count == 2)
                    {
                        numberToChar = "h";
                    }
                    else
                    {
                        numberToChar = "i";
                    }
                }
                else if (numberToChar.Contains("5"))
                {
                    int count = numberToChar.Length;
                    if (count == 1)
                    {
                        numberToChar = "j";
                    }
                    else if (count == 2)
                    {
                        numberToChar = "k";
                    }
                    else
                    {
                        numberToChar = "l";
                    }
                }
                else if (numberToChar.Contains("6"))
                {
                    int count = numberToChar.Length;
                    if (count == 1)
                    {
                        numberToChar = "m";
                    }
                    else if (count == 2)
                    {
                        numberToChar = "n";
                    }
                    else
                    {
                        numberToChar = "o";
                    }
                }
                else if (numberToChar.Contains("7"))
                {
                    int count = numberToChar.Length;
                    if (count == 1)
                    {
                        numberToChar = "p";
                    }
                    else if (count == 2)
                    {
                        numberToChar = "q";
                    }
                    else if (count == 3)
                    {
                        numberToChar = "r";
                    }
                    else
                    {
                        numberToChar = "s";
                    }
                }
                else if (numberToChar.Contains("8"))
                {
                    int count = numberToChar.Length;
                    if (count == 1)
                    {
                        numberToChar = "t";
                    }
                    else if (count == 2)
                    {
                        numberToChar = "u";
                    }
                    else
                    {
                        numberToChar = "v";
                    }
                }
                else if (numberToChar.Contains("9"))
                {
                    int count = numberToChar.Length;
                    if (count == 1)
                    {
                        numberToChar = "w";
                    }
                    else if (count == 2)
                    {
                        numberToChar = "x";
                    }
                    else if (count == 3)
                    {
                        numberToChar = "y";
                    }
                    else
                    {
                        numberToChar = "z";
                    }
                }
                else
                {
                    numberToChar = " ";
                }
                message += numberToChar;
            }
            Console.WriteLine(message);
        }
    }
}
