using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03_Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            int allCommands = int.Parse(Console.ReadLine());


            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < allCommands; i++)
            {
                List<int> command = Console.ReadLine().Split().Select(int.Parse).ToList();
                if (command[0] == 2)
                {
                    if (myStack.Count > 0)
                    {
                        myStack.Pop();
                    }

                }
                else if (command[0] == 3)
                {
                    if (myStack.Count > 0)
                    {
                        foreach (var item in myStack)
                        {
                            if (item > max)
                            {
                                max = item;
                            }
                        }
                        Console.WriteLine(max);
                    }
                }
                else if (command[0] == 4)
                {
                    if (myStack.Count > 0)
                    {
                        foreach (var item in myStack)
                        {
                            if (item < min)
                            {
                                min = item;
                            }
                        }
                        Console.WriteLine(min);
                    }
                }
                else
                {
                    myStack.Push(command[1]);
                }
            }
            if (myStack.Count > 0)
            {

                List<int> finalResult = new List<int>();
                foreach (var item in myStack)
                {
                    finalResult.Add(item);
                }

                Console.WriteLine(string.Join(", ", finalResult));
            }
        }
    }
}
