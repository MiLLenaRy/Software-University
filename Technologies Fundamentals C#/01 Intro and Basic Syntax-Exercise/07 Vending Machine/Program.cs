using System;

namespace _7._Vending_M
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine());

            double balance = 0;
            while (input != "Start")
            {
                double coint = double.Parse(input);

                if (coint == 0.1 ||
                    coint == 0.2 ||
                    coint == 0.5 ||
                    coint == 1 ||
                    coint == 2)
                {
                    balance += coint;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coint}");
                }

                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                double productPrice = 0;

                switch (input)
                {
                    case "Nuts":
                        productPrice = 2;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (balance >= productPrice && productPrice > 0)
                {
                    string productToLower = input.ToLower();
                    Console.WriteLine($"Purchased {productToLower}");
                    balance -= productPrice;
                }
                else if (balance < productPrice && productPrice > 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {balance:F2}");

        }
    }
}
