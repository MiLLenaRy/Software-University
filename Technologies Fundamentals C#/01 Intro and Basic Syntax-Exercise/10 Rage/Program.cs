using System;

namespace _10_Rage
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headSetCounter = 0;
            int mouseCounter = 0;
            int keyboardCounter = 0;
            int displayCounter = 0;
            double totalPrice = 0;


            for (int i = 1; i <= lostGames; i++)
            {
                if (i > 0 && i % 2 == 0)
                {
                    headSetCounter++;
                }
                if (i > 0 && i % 3 == 0)
                {
                    mouseCounter++;
                    if (headSetCounter > 0 && headSetCounter % 3 == 0)
                    {
                        keyboardCounter++;

                        if (keyboardCounter > 0 && keyboardCounter % 2 == 0)
                        {
                            displayCounter++;
                        }
                    }
                }

            }
            totalPrice = (headSetPrice * headSetCounter) + (mouseCounter * mousePrice) + (keyboardCounter * keyboardPrice) + (displayCounter * displayPrice);
            Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");
        }
    }
}
