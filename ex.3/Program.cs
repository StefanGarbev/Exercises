using System;
using System.Collections.Generic;
using System.Linq;

namespace ex._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            { 
                string [] phone = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string phoneIndex0 = phone[0];
                if (phoneIndex0 == "Add")
                {
                    string phoneIndex2 = phone[2];
                    if (phones.Contains(phoneIndex2))
                    {
                        continue;
                    }
                    else
                    {
                        phones.Add(phoneIndex2);
                    }
                }
                else if (phoneIndex0 == "Remove")
                {
                    string Index2 = phone[2];

                    if (phones.Contains(Index2))
                    {
                        phones.Remove(Index2);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (phoneIndex0 == "Bonus")
                {
                    string index3 = phone[3];
                    char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
                    string[] devidedString = index3.Split(delimiterChars);
                    string indexDevided0 = devidedString[0];
                    string indexDevided1 = devidedString[1];

                    for (int i = 0; i < phones.Count; i++)
                    {
                        if (phones[i] == indexDevided0)
                        {
                            phones.Insert(i + 1, indexDevided1);
                            continue;
                        }
                    }
                }
                else if (phoneIndex0 == "Last")
                { 
                    string index2 = phone[2];
                    if (phones.Contains(index2))
                    {
                        phones.Remove(index2);
                        phones.Add(index2);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
