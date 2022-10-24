using System;
using System.Collections.Generic;
using System.Linq;

namespace ex._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> productFromGroceries = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] cmdArgs = command.Split(' ');
                string commandIndex0 = cmdArgs[0];

                if (commandIndex0 == "Urgent")
                {
                    string commandIndex1 = cmdArgs[1];

                    if (productFromGroceries.Contains(commandIndex1))
                    {
                        continue;
                    }
                    else
                    {
                        productFromGroceries.Insert(0, commandIndex1);
                    }

                }
                else if (commandIndex0 == "Unnecessary")
                {
                    string commandIndex1 = cmdArgs[1];

                    for (int i = 0; i < productFromGroceries.Count; i++)
                    {
                        if (commandIndex1 == productFromGroceries[i])
                        {
                            productFromGroceries.Remove(productFromGroceries[i]);
                            continue;
                        }
                    }
                }
                else if (commandIndex0 == "Correct")
                {
                    string commandIndex1 = cmdArgs[1];
                    string commandIndex2 = cmdArgs[2];

                    for (int i = 0; i < productFromGroceries.Count; i++)
                    {
                        if (commandIndex1 == productFromGroceries[i])
                        {
                            productFromGroceries[i] = commandIndex2;
                            continue;
                        }
                    }
                }
                else if (commandIndex0 == "Rearrange")
                {
                    string commandIndex1 = cmdArgs[1];

                    for (int i = 0; i < productFromGroceries.Count; i++)
                    {
                        if (commandIndex1 == productFromGroceries[i])
                        {
                            productFromGroceries.Remove(productFromGroceries[i]);
                            productFromGroceries.Add(commandIndex1);
                        }
                    }
                }

               // command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", productFromGroceries));
        }
    }
}
