using System;

namespace _03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double discount = 0;
            double price = 0;

            if (typeOfGroup == "Students")
            {
                if (numberOfPeople >= 30)
                {
                    discount = 0.85;
                }
                if (dayOfWeek == "Friday")
                {
                    price = 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (numberOfPeople >= 100)
                {
                    numberOfPeople -= 10;
                }
                if (dayOfWeek == "Friday")
                {
                    price = 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 16;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                if (numberOfPeople >= 10 && numberOfPeople <= 20)
                {
                    discount = 0.95;
                }
                if (dayOfWeek == "Friday")
                {
                    price = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 22.50;
                }
            }


            double priceForAllPeople = numberOfPeople * price;
            if (discount > 0)
            {
                Console.WriteLine($"Total price: {priceForAllPeople * discount:F2}");
            }
            else
            {
                Console.WriteLine($"Total price: {priceForAllPeople:F2}");
            }


        }
    }
}
