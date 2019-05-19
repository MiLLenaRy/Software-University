using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05__Fashion_Boutique
{
    class FashionBoutique
    {
        static void Main(string[] args)
        {
            List<int> allClothes = Console.ReadLine().Split().Select(int.Parse).ToList();

            int capacity = int.Parse(Console.ReadLine());

            Stack<int> myStack = new Stack<int>();
            foreach (var item in allClothes)
            {
                myStack.Push(item);
            }
            int counter = 1;
            int capaciryLeft = capacity;
            while (myStack.Count>0)
            {
                if (capaciryLeft>myStack.Peek())
                {
                    capaciryLeft -= myStack.Peek();
                    myStack.Pop();
                }
                else if (capaciryLeft==myStack.Peek() && myStack.Count==1)
                {
                    capaciryLeft -= myStack.Peek();
                    myStack.Pop();                    
                }
                else if (capaciryLeft == myStack.Peek() && myStack.Count != 1)
                {
                    myStack.Pop();
                    counter++;
                    capaciryLeft = capacity;
                }
                else
                {
                    counter++;
                    capaciryLeft = capacity;
                }
            }
            Console.WriteLine(counter);

            
        }
    }
}
