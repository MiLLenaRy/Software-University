using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04__Fast_Food
{
    class FastFood
    {
        static void Main(string[] args)
        {
            int allFood = int.Parse(Console.ReadLine());

            int bigerOrder = int.MinValue;
            Stack<int> myStack = new Stack<int>();
            List<int> clients = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            for (int a = 0; a < clients.Count; a++)
            {
                myStack.Push(clients[a]);
                if (clients[a] > bigerOrder)
                {
                    bigerOrder = clients[a];
                }
            }
            for (int b = 0; b < clients.Count; b++)
            {
                if (myStack.Peek() <= allFood)
                {
                    int thisOrde = myStack.Peek();
                    allFood -= thisOrde;
                    myStack.Pop();
                }
                else
                {
                    Console.WriteLine(bigerOrder);
                    Console.Write($"Orders left: ");
                    foreach (var item in myStack)
                    {                      
                        
                        Console.Write(item+" ");
                                                                     
                    }
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine(bigerOrder);
            Console.WriteLine("Orders complete");
        }
    }
}
