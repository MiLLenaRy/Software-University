using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_Reverse_Strings
{
    class StackReverse
    {
        static void Main(string[] args)
        {
            string input= Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (var oneChars in input)
            {
                stack.Push(oneChars);
            }

            while (stack.Count>0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();

        }
    }
}
