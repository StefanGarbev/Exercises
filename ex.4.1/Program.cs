using System;

namespace Ex._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal food = decimal.Parse(Console.ReadLine());
            decimal hay = decimal.Parse(Console.ReadLine());
            decimal cover = decimal.Parse(Console.ReadLine());
            decimal guineaPigWeight = decimal.Parse(Console.ReadLine());

            for (int i = 1; i <= 30; i++)
            {
                food -= 0.3M;

                if (i % 2 == 0)
                {
                    hay -= food * 0.05M;
                }

                if (i % 3 == 0)
                {
                    cover -= guineaPigWeight / 3;
                }

                if (food < 0 || hay < 0 || cover < 0)
                {
                    break;
                }
            }
            if (food > 0 && hay > 0 && cover > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hay:f2}, Cover: {cover:f2}.");
            }
            else
            {
                Console.WriteLine($"Merry must go to the pet store!");
            }
        }
    }
}
