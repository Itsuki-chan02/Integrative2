using System;

namespace ComputerAverageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Please enter 5 grades:");

            double grade1 = double.Parse(Console.ReadLine());
            double grade2 = double.Parse(Console.ReadLine());
            double grade3 = double.Parse(Console.ReadLine());
            double grade4 = double.Parse(Console.ReadLine());
            double grade5 = double.Parse(Console.ReadLine());

            double average = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;
            int roundedAverage = (int)Math.Round(average);






        }
    }
}
