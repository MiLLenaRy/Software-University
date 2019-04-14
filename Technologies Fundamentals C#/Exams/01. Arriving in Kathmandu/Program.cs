using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            string decript = @"([!]*[#]*[@]*[$]*[A-Z]*[a-z]*[?]*[0-9]*)+";

            while ((command=Console.ReadLine())!= "Last note")
            {                
                List<string> array = command.Split("=").ToList();
                string firstWord = array[0];
                Match cheker = Regex.Match(firstWord, decript);

                if (firstWord.Length==cheker.Length)
                {
                    string number = string.Empty;
                    string[] secondArray = array[1].Split("<<").ToArray();
                    int counter = 0;
                    for (int x = 0; x < secondArray[0].Length; x++)
                    {
                             
                        if (char.IsDigit(secondArray[0][x]))
                        {
                            counter++;
                            number += secondArray[0][x];
                        }
                        
                    }                   
                    int numbers = 0;
                    if (counter==secondArray[0].Length)
                    {
                        numbers = int.Parse(number);
                        
                    }                 
                    if (secondArray[1].Length==numbers)
                    {
                        var finalResoult = new StringBuilder();
                        for (int i = 0; i < firstWord.Length; i++)
                        {
                            if (char.IsLetterOrDigit(firstWord[i]))
                            {
                                finalResoult.Append(firstWord[i]);
                            }
                        }
                        finalResoult.Append(" -> ");
                        for (int i = 0; i < secondArray[1].Length; i++)
                        {
                            finalResoult.Append(secondArray[1][i]);
                        }
                        Console.WriteLine("Coordinates found! " + finalResoult);
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }            
            }
        }
    }
}
