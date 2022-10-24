using System;

namespace ex._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());

            int studentCount = int.Parse(Console.ReadLine());

            int time = 24;
            int timerToFinish = 0;
            int employeesEfficiencyForHour = firstEmployee + secondEmployee + thirdEmployee;
            int sumOfFinishedStudent = 0;

            for (int i = 1; i < time; i++)
            {

                if (sumOfFinishedStudent >= studentCount)
                {
                    Console.WriteLine($"Time needed: {timerToFinish}h.");
                    break;
                }
                else if (sumOfFinishedStudent < studentCount)
                {
                    if (i % 4 == 0)
                    {
                        timerToFinish += 1;

                        //sumOfFinishedStudent+= employeesEfficiencyForHour;
                    }
                    else
                    {
                        timerToFinish++;
                        sumOfFinishedStudent += employeesEfficiencyForHour;
                    }
                }
                
            }
            //Console.WriteLine($"Time needed: {timerToFinish}h.");
        }
    }
}
