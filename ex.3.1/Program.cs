using System;

namespace ex._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string distanceValue = Console.ReadLine(); 
            int wonCnt = 0;

            while (distanceValue != "End of battle")
            {
                int enemyDistance = 0;
                enemyDistance = int.Parse(distanceValue);

                if (initialEnergy >= enemyDistance)
                {
                    wonCnt++;
                    initialEnergy -= enemyDistance;
                    if (wonCnt % 3 == 0)
                    {
                        initialEnergy += wonCnt;
                    }
                }
                else if (initialEnergy < enemyDistance)
                {
                    initialEnergy-=enemyDistance;
                    break;
                }
                distanceValue = Console.ReadLine();
            }
            if (initialEnergy >= 0)
            {
                Console.WriteLine($"Won battles: {wonCnt}. Energy left: {initialEnergy}");
            }
            else
            {
                Console.WriteLine($"Not enough energy! Game ends with {wonCnt} won battles and 0 energy");
            }
        }
    }
}
