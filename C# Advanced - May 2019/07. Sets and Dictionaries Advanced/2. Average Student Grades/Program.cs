using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] student = Console.ReadLine()
                    .Split()
                    .ToArray();

                string studentName = student[0];
                double value = double.Parse(student[1]);
                if (!dict.ContainsKey(studentName))
                {
                    dict.Add(studentName, new List<double>());
                    dict[studentName].Add(value);
                }
                else
                {
                    dict[studentName].Add(value);
                }
            }
            foreach (var pair in dict)
            {
                var name = pair.Key;
                var studentGrades = pair.Value;
                var average = studentGrades.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in studentGrades)
                    Console.Write($"{grade:f2} ");
                    Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
