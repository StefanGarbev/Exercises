using System;
using System.Linq;

namespace ex._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputTargets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] outTargets = new int[inputTargets.Length];
            string targetIndex = string.Empty;
            int shootCnt = 0;
            for (int i = 0; i < inputTargets.Length; i++)
            {
                outTargets[i] = inputTargets[i];
            }

            while ((targetIndex = Console.ReadLine()) != "End")
            { 
                
                int index = int.Parse(targetIndex);

                if (index < 0 && index > inputTargets.Length-1)
                {
                    continue;
                }
                else if (index >= 0 && index <= inputTargets.Length-1)
                {
                    shootCnt++;
                    int currValue = outTargets[index];
                    outTargets[index] = -1;
                    for (int i = 0; i < inputTargets.Length; i++)
                    {
                        if (currValue >= outTargets[i])
                        {
                            if (outTargets[i] == -1)
                            {
                                continue;
                            }
                            else
                            {
                                outTargets[i] += currValue;
                            }
                        }
                        else if (currValue < outTargets[i])
                        {
                            if (outTargets[i] == -1)
                            {
                                continue;
                            }
                            else
                            {
                                outTargets[i] -= currValue;
                            }
                        }
                    }
                }
            }
            Console.Write($"Shot targets: {shootCnt} -> ");
            Console.WriteLine(string.Join(" ", outTargets));
        }
    }
}
