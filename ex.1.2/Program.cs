using System;
using System.Linq;

namespace ex._1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWaintingLiftPeople = int.Parse(Console.ReadLine());
            int[] liftCondition = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < liftCondition.Length; i++)
            {
                int liftCounter = liftCondition[i];
                while (liftCondition[i] != 4 && numberOfWaintingLiftPeople > 0)
                {
                    liftCounter++;
                    numberOfWaintingLiftPeople--;

                    liftCondition[i] = liftCounter;

                }
                liftCounter = 0;
            }

            PrintInfo(numberOfWaintingLiftPeople, liftCondition);

        }

        private static void PrintInfo(int numberOfWaintingLiftPeople, int[] liftCondition)
        {
            int sumOfLiftSetats = 0;
            sumOfLiftSetats = liftCondition.Length * 4;

            int sumOfPeopleInLift = 0;
            for (int i = 0; i < liftCondition.Length; i++)
            {
                sumOfPeopleInLift += liftCondition[i];

            }
            //Console.WriteLine(sumOfPeopleInLift);

            if (sumOfLiftSetats > sumOfPeopleInLift)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", liftCondition));
            }
            else if (sumOfLiftSetats == sumOfPeopleInLift && numberOfWaintingLiftPeople > 0)
            {

                Console.WriteLine($"There isn't enough space! {numberOfWaintingLiftPeople} people in a queue!");
                Console.WriteLine(string.Join(" ", liftCondition));
            }
            else if (sumOfLiftSetats == sumOfPeopleInLift && numberOfWaintingLiftPeople == 0)
            {
                Console.WriteLine(string.Join(" ", liftCondition));
            }
        }
    }
}
