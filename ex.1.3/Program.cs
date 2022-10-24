using System;
using System.Collections.Generic;
using System.Linq;

namespace ex._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sequenceOfNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = string.Empty;
            int moviesCnt = 0;
            string toDelete = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                moviesCnt++;
                string[] commandArr = command.Split(' ',StringSplitOptions.RemoveEmptyEntries);

                int indexArr0 = int.Parse(commandArr[0]);
                int indexArr1 = int.Parse(commandArr[1]);

                if ( indexArr0 < 0 || indexArr0 > sequenceOfNumbers.Count-1 
                  || indexArr1 < 0 || indexArr1 > sequenceOfNumbers.Count-1)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    int middleindex = sequenceOfNumbers.Count / 2;
                    string addedElement = $"-{moviesCnt}a";
                    sequenceOfNumbers.Insert(middleindex, addedElement);
                    sequenceOfNumbers.Insert(middleindex + 1, addedElement);
                }
                else
                {

                    if (sequenceOfNumbers[indexArr0] == sequenceOfNumbers[indexArr1])
                    {
                        
                        Console.WriteLine($"Congrats! You have found matching elements - {sequenceOfNumbers[indexArr0]}!");
                        toDelete = sequenceOfNumbers[indexArr0];
                        sequenceOfNumbers.Remove(toDelete);
                        sequenceOfNumbers.Remove(toDelete);

                    }
                    else if (sequenceOfNumbers[indexArr0] != sequenceOfNumbers[indexArr1])
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                if (sequenceOfNumbers.Count == 0)
                {
                    Console.WriteLine($"You have won in {moviesCnt} turns!");
                    return;
                }
            }
            if (command == "end" && sequenceOfNumbers.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ",sequenceOfNumbers));
            }
        }
    }
}
