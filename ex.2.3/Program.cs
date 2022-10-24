using System;
using System.Collections.Generic;
using System.Linq;

namespace ex._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] seqienceOfNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            double average = 0;
            int sumOfNumbers = 0;
            int currNum= 0;
            string currNumStr = string.Empty;
            int top5Cnt = 0;
            bool number = false;
            //string noNum = string.Empty;
            List <string> numbers = new List<string>();
            //List<string> noNumbers = new List<string>();    

            for (int i = 0; i < seqienceOfNumbers.Length; i++)
            { 
                sumOfNumbers+=seqienceOfNumbers[i];
            }
            average =(double)sumOfNumbers /seqienceOfNumbers.Length;
            for (int i = 0; i < seqienceOfNumbers.Length; i++)
            {

                if (seqienceOfNumbers[i] > average)
                {
                    number = true;
                    top5Cnt++;
                    currNum = seqienceOfNumbers[i];
                    currNumStr = currNum.ToString();
                    numbers.Add(currNumStr);

                }
                
                
            }

            numbers.Sort();
            numbers.Reverse();

            if (top5Cnt > 5 && number==true)
            {
                List<string> currNumTop5 = new List<string>();
                string num5 = string.Empty;
                for (int i = 0; i < 5; i++)
                {
                    num5 = numbers[i];
                    currNumTop5.Add(num5);
                }
                Console.WriteLine(String.Join(" ", currNumTop5));
            }
            else if (top5Cnt < 5 && number==true)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
            else if (number == false)
            {
                Console.WriteLine("No");
            }
           
        }
    }
}
