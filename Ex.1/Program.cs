using System;

namespace ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsNumber = int.Parse(Console.ReadLine());
            double packageOfFlourPrice = double.Parse(Console.ReadLine());
            double singleEggPrice = double.Parse(Console.ReadLine());
            double singleApronPrice = double.Parse(Console.ReadLine());
            double freePackages = 0;
            for (int i = 1; i <= studentsNumber; i++)
            {
                if (i % 5 == 0)
                { 
                    freePackages++;
                }
            }
            double percent = Math.Ceiling(studentsNumber * 0.20);
            double totalApronsPrice = singleApronPrice * (studentsNumber + percent);
            double totalEggsPrice = singleEggPrice * 10 * studentsNumber;
            double totalFlourPrice = packageOfFlourPrice * (studentsNumber - freePackages);

            double totalPrice = totalApronsPrice + totalEggsPrice + totalFlourPrice;
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Items purchased for {totalPrice:f2}$.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(budget-totalPrice):f2}$ more needed.");
            }

        }
    }
}
