using System;
using System.Linq;

namespace ex._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string argPosittion0 = cmdArgs[0];

                if (argPosittion0 == "swap")
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int index2 = int.Parse(cmdArgs[2]);
                    int currNum = 0;

                    currNum = inputNumbers[index2];
                    inputNumbers[index2] = inputNumbers[index1];
                    inputNumbers[index1] = currNum;
                    //Console.WriteLine(String.Join(",", inputNumbers));
                }
                else if (argPosittion0 == "multiply")
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int index2 = int.Parse(cmdArgs[2]);

                    inputNumbers[index1] *= inputNumbers[index2];
                    //Console.WriteLine(String.Join(",", inputNumbers));
                }
                else if (argPosittion0 == "decrease")
                {
                    for (int i = 0; i < inputNumbers.Length; i++)
                    {
                        inputNumbers[i] -= 1;

                    }
                    //Console.WriteLine(String.Join(",", inputNumbers));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(", ", inputNumbers));
        }
    }
}
