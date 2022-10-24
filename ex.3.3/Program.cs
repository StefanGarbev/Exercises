using System;
using System.Collections.Generic;
using System.Linq;

namespace ex._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string arguments = commandArgs[0];

                if (arguments == "Shoot")
                {
                    int index = int.Parse(commandArgs[1]);
                    int power = int.Parse(commandArgs[2]);


                    if (index >= 0 && index < number.Count)
                    {
                        number[index] -= power;
                        if (number[index] <= 0)
                        {
                            number.RemoveAt(index);
                        }
                    }
                    else
                    {
                        continue;
                    }
                    //Console.WriteLine(String.Join(" ", number));
                }
                else if (arguments == "Add")
                {
                    int index = int.Parse(commandArgs[1]);
                    int value = int.Parse(commandArgs[2]);


                    if (index >= 0 && index < number.Count)
                    {
                        number.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    //Console.WriteLine(String.Join(" ", number));
                }
                else if (arguments == "Strike")
                {
                    int index = int.Parse(commandArgs[1]);
                    int radius = int.Parse(commandArgs[2]);


                    if (index - radius >= 0 && index + radius < number.Count)
                    {
                        int range = 1 + ((index + radius) - (index - radius));
                        int startRangeIndex = index - radius;
                        number.RemoveRange(startRangeIndex, range);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join("|", number));
        }
    }
}

