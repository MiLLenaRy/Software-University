using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08__Balanced_Parentheses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            Stack<char> stackOfParanteses = new Stack<char>();

            char[] input = Console.ReadLine().ToCharArray();
            char[] openParanteses = new char[] { '(', '{', '[' };

            bool isValid = true;
            if (!openParanteses.Contains(input[0]))
            {
                isValid = false;
            }

            foreach (var item in input)
            {
                if (openParanteses.Contains(item))
                {
                    stackOfParanteses.Push(item);
                    continue;
                }

                if (stackOfParanteses.Count==0)
                {
                    isValid = false;
                    break;
                }

                if (stackOfParanteses.Peek()=='(' && item==')')
                {
                    stackOfParanteses.Pop();
                }
                else if (stackOfParanteses.Peek() == '{' && item == '}')
                {
                    stackOfParanteses.Pop();
                }
                else if (stackOfParanteses.Peek() == '[' && item == ']')
                {
                    stackOfParanteses.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
