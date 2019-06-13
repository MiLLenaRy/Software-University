using System;using System.Collections.Generic;using System.IO;using System.IO.Compression;
using System.Linq;using System.Text;using System.Text.RegularExpressions;

namespace _4._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)               
                .ToArray();

            foreach (var result in prices)
            {
                double vat=1.2;
                Console.WriteLine($"{vat*result:F2}");
            }
        }
    }
}
