using System;

namespace ex._5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);
            int healt = 100;
            int bitcoins = 0;
            for (int i = 0; i < rooms.Length; i++)
            {

                string[] cmdArgs = rooms[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string arg = cmdArgs[0];

                if (arg == "potion")
                {
                    int index = int.Parse(cmdArgs[1]);
                    healt += index;
                    if (healt >= 100)
                    {
                        index = index - (healt - 100);
                        healt = 100;
                    }
                    Console.WriteLine($"You healed for {index} hp.");
                    Console.WriteLine($"Current health: {healt} hp.");
                }
                else if (arg == "chest")
                {
                    int index = int.Parse(cmdArgs[1]);
                    bitcoins += index;
                    Console.WriteLine($"You found {index} bitcoins.");
                }
                else 
                {
                    int index = int.Parse(cmdArgs[1]);
                    healt -= index;

                    if (healt <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {arg}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                    else if (healt > 0)
                    {
                        Console.WriteLine($"You slayed {arg}.");
                    }
                }
            }
            if (healt > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {healt}");
            }
        }
    }
}
