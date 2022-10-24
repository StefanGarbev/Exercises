using System;

namespace ex._5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            int LecturesCount = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            double studentAttendance = 0;
            double maxBonusPoint = 0;
            int max = 0;
            int maxAttendance = 0;
            for (int i = 1; i <= studentCount; i++)
            {
                studentAttendance = int.Parse(Console.ReadLine());

                maxBonusPoint =  studentAttendance * (5 + additionalBonus)/ LecturesCount;
                if (max <= maxBonusPoint)
                {
                    double MaxBonusCeiling = Math.Ceiling(maxBonusPoint);
                    max = (int)MaxBonusCeiling;
                    maxAttendance =(int)studentAttendance;
                }

            }
            Console.WriteLine($"Max Bonus: {max}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
