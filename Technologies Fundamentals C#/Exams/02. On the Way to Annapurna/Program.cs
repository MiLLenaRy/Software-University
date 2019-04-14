using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;

            var dict = new Dictionary<string, List<string>>();

            while ((command=Console.ReadLine())!="END")
            {
                string[] array = command.Split("->").ToArray();
                string option = array[0];
                string type = array[1];

                
                if (option=="Add")
                {
                    List<string> lastLine = array[2].Split(',').ToList();
                    
                    if (!dict.ContainsKey(type))
                    {
                        dict.Add(type, new List<string>());
                    }
                    for (int b = 0; b < lastLine.Count; b++)
                    {
                        dict[type].Add("<<"+lastLine[b]+">>");
                    }                    
                }
                else if(option == "Remove")
                {                
                    dict.Remove(type);
                }
            }
            Console.WriteLine("Stores list:");
            foreach (var item in dict.OrderByDescending(x=>x.Value.Count).ThenByDescending(x=>x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var name in item.Value)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
