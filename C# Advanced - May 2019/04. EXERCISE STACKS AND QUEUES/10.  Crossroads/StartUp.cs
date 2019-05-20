using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace _10.__Crossroads
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Queue<string> queueOfCars = new Queue<string>();

            int greenLinghtDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            bool isHitted = false;
            string hittedCarName = string.Empty;
            char hittedSymbol = '\0';
            int totalCars = 0;

            while (input != "END")
            {
                if (input != "green")
                {
                    queueOfCars.Enqueue(input);
                    input = Console.ReadLine();
                    continue;
                }

                int currentGreenLigntDuration = greenLinghtDuration;

                while (currentGreenLigntDuration > 0 && queueOfCars.Count > 0)
                {
                    string carName = queueOfCars.Dequeue();
                    int carLenght = carName.Length;

                    if (currentGreenLigntDuration - carLenght >= 0)
                    {
                        currentGreenLigntDuration -= carLenght;
                        totalCars++;
                    }
                    else
                    {
                        currentGreenLigntDuration += freeWindowDuration;

                        if (currentGreenLigntDuration - carLenght >= 0)
                        {
                            totalCars++;
                            break;
                        }
                        else
                        {
                            isHitted = true;
                            hittedCarName = carName;
                            hittedSymbol = carName[currentGreenLigntDuration];
                            break;
                        }
                    }
                }

                if (isHitted)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (isHitted)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{hittedCarName} was hit at {hittedSymbol}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{totalCars} total cars passed the crossroads.");
            }
        }
    }
}
