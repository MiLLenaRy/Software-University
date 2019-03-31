using System;

namespace _09_Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int extract = int.Parse(Console.ReadLine());

            int herbs = 0;
            int days = 0;

            while (extract >= 100)
            {

                herbs += extract - 26;
                extract -= 10;
                days++;

            }
            if (herbs > 25)
            {
                herbs -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(herbs);
        }
    }
}
