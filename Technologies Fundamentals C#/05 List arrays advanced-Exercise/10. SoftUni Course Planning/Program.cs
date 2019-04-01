using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            string comand = Console.ReadLine();

            while (comand != "course start")
            {
                string[] arrayComand = comand.Split(':').ToArray();
                string command = arrayComand[0];
                switch (command)
                {
                    case "Add":
                        Add(input, comand);
                        break;
                    case "Insert":
                        Insert(input, comand);
                        break;
                    case "Remove":
                        Remove(input, comand);
                        break;
                    case "Swap":
                        Swap(input, comand);
                        break;
                    case "Exercise":
                        Exercise(input, comand);
                        break;
                }
                comand = Console.ReadLine();
            }

            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{input[i]}");
            }
        }

        public static List<string> Exercise(List<string> input, string comand)
        {
            string[] arrayComand = comand.Split(':').ToArray();
            string title = arrayComand[1];
            bool isContainLesson = input.Contains(title);
            bool isContainExercise = input.Contains(title + "-Exercise");
            if (isContainLesson == true)
            {
                if (isContainExercise == false)
                {
                    int index = input.FindIndex(x => x == title);
                    input.Insert(index + 1, title + "-Exercise");
                }
            }
            else
            {
                input.Add(title);
                input.Add(title + "-Exercise");
            }
            return input;
        }

        public static List<string> Swap(List<string> input, string comand)
        {
            string[] arrayComand = comand.Split(':').ToArray();
            string firstTitle = arrayComand[1];
            string secondTitle = arrayComand[2];
            bool isContain1 = input.Contains(firstTitle);
            bool isConatain2 = input.Contains(secondTitle);

            if (isContain1 == true && isConatain2 == true)
            {
                bool isContainExercise1 = input.Contains($"{firstTitle}-Exercise");
                bool isContainExercise2 = input.Contains($"{secondTitle}-Exercise");
                int index1 = input.FindIndex(x => x == $"{firstTitle}");
                string keep = input[index1];
                string keepExercise = string.Empty;
                int index2 = input.FindIndex(x => x == $"{secondTitle}");
                int index1Exercise = 0;
                int index2Exercise = 0;
                input[index1] = input[index2];
                input[index2] = keep;
                if (isContainExercise1 == true)
                {
                    index1Exercise = input.FindIndex(x => x == $"{firstTitle}-Exercise");
                    input.Insert(index2 + 1, input[index1Exercise]);
                    input.RemoveAt(index1Exercise + 1);
                }
                if (isContainExercise2 == true)
                {
                    index2Exercise = input.FindIndex(x => x == $"{secondTitle}-Exercise");
                    input.Insert(index1 + 1, input[index2Exercise]);
                    input.RemoveAt(index2Exercise + 1);
                }
            }
            return input;
        }

        public static List<string> Remove(List<string> input, string comand)
        {
            string[] arrayComand = comand.Split(':').ToArray();
            string title = arrayComand[1];
            bool isContain = input.Contains(title);
            bool isContainExercise = input.Contains($"{title} + -Exercise");

            if (isContain == true)
            {
                int index = input.FindIndex(x => x == $"{title}");
                input.RemoveAt(index);

                if (isContainExercise == true)
                {
                    int indexExercise = input.FindIndex(x => x == $"{title} + -Exercise");
                    input.RemoveAt(indexExercise);
                }
            }
            return input;
        }

        public static List<string> Insert(List<string> input, string comand)
        {
            string[] arrayComand = comand.Split(':').ToArray();
            string title = arrayComand[1];
            int index = int.Parse(arrayComand[2]);
            bool isContain = input.Contains(title);

            if (isContain == false)
            {
                input.Insert(index, title);
            }

            return input;
        }

        public static List<string> Add(List<string> input, string comand)
        {
            string[] comandArray = comand.Split(':').ToArray();
            string title = comandArray[1];
            bool isContains = input.Contains(title);

            if (isContains == false)
            {
                input.Add(title);
            }

            return input;
        }
    }
}
