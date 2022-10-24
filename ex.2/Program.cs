using System;
using System.Collections.Generic;

namespace ex._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] routeArr = Console.ReadLine()
                .Split("||", StringSplitOptions.RemoveEmptyEntries);
            int fuel = int.Parse (Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());

            for (int i = 0; i < routeArr.Length; i++)
            {
               string commandArr = routeArr[i];
                char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
                string[] command = commandArr.Split(delimiterChars);
                string index0 = command[0];

                
                
                if (index0 == "Travel")
                {
                    int index1 = int.Parse(command[1]);
                    if (index1 <= fuel)
                    {
                        fuel -= index1;
                        Console.WriteLine($"The spaceship travelled {index1} light-years.");
                    }
                    else if (index1 > fuel)
                    {
                        Console.WriteLine("Mision faild.");
                        break;
                    }
                    
                }
                else if (index0 == "Enemy")
                {
                    int index1 = int.Parse(command[1]);

                    if (ammunition >= index1)
                    {
                        ammunition -= index1;
                        Console.WriteLine($"An enemy with {index1} armour is defeated.");
                    }
                    else if (ammunition < index1 && fuel >= 2 * index1)
                    {
                        fuel = fuel - index1 * 2;
                        Console.WriteLine($"An enemy with {index1} armour is outmaneuvered.");
                    }
                    else if (ammunition < index1 && fuel < 2 * index1)
                    {
                        Console.WriteLine("Mission failed.");
                        break;
                    }
                    
                }
                else if (index0 == "Repair")
                {
                    int index1 = int.Parse(command[1]);
                    fuel+=index1;
                    ammunition += 2 * index1;

                    Console.WriteLine($"Ammunitions added: {2*index1}.");
                    Console.WriteLine($"Fuel added: {index1}.");
                }
                else if (index0 == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    break;
                }
            } 
        }
    }
}
