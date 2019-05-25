using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _6._Parking_Lot
{
    public class StartIn
    {
        public static void Main(string[] args)
        {
            string commad;
            var vip = new HashSet<string>();
            var regular = new HashSet<string>();

            while ((commad = Console.ReadLine()) != "PARTY")
            {
                char firstLater = commad[0];
                if (char.IsDigit(firstLater))
                {
                    vip.Add(commad);
                }
                else
                {
                    regular.Add(commad);
                }
            }
            while ((commad = Console.ReadLine()) != "END")
            {
                vip.Remove(commad);
                regular.Remove(commad);
            }

            int missingGuest = vip.Count + regular.Count;
            Console.WriteLine(missingGuest);
            foreach (var item in vip)
            {
                Console.WriteLine(item);
            }
            foreach (var item in regular)
            {
                Console.WriteLine(item);
            }
        }
    }
}
