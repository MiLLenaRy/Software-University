using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_Simple_Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] expression = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>(expression.Reverse());


            while (stack.Count>1)
            {
                int operandOne = int.Parse(stack.Pop());
                string opr = stack.Pop();
                int operandTwo = int.Parse(stack.Pop());

                switch (opr)
                {
                    case "+":
                        stack.Push((operandOne + operandTwo).ToString());
                        break;
                    case "-":
                        stack.Push($"{operandOne-operandTwo}");
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(stack.Pop());

        }
    }
}
