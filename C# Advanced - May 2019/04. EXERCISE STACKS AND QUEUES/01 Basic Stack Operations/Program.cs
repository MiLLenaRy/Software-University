using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01_Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            List<int> command = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int pushElements = command[0];
            int popElements = command[1];
            int finalElement = command[2];

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                myStack.Push(numbers[i]);
            }
            if (popElements<pushElements)
            {
                for (int i = 1; i <= popElements; i++)
                {
                    myStack.Pop();
                }
            }
            else
            {
                for (int i = 1; i <= pushElements; i++)
                {
                    myStack.Pop();
                }
                myStack.Push(0);
            }

            if (myStack.Contains(finalElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(myStack.Peek());
            }
        }
    }
}
