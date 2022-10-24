using System;
using System.Collections.Generic;
using System.Linq;

namespace ex._5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputInventory = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = string.Empty;

            while((command = Console.ReadLine()) != "Craft!")
            {
                string[] cmdArgs = command
                    .Split();
                string Index0 = cmdArgs[0];

                if (Index0 == "Collect")
                {
                    string index2 = cmdArgs[2];

                    if (inputInventory.Contains(index2))
                    {
                        continue;
                    }
                    else
                    {
                        inputInventory.Add(index2);
                    }

                }
                else if (Index0 == "Drop")
                {
                    string index2 = cmdArgs[2];
                    if (inputInventory.Contains(index2))
                    {
                        inputInventory.Remove(index2);
                    }
                }
                else if (Index0 == "Combine")
                {
                    string index3 = cmdArgs[3];
                    char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

                    string[] devidedString = index3.Split(delimiterChars);
                    string indexDevided0 = devidedString[0];
                    string indexDevided1 = devidedString[1];

                    for (int i = 0; i < inputInventory.Count; i++)
                    {
                        if (inputInventory[i] == indexDevided0)
                        {
                            inputInventory.Insert(i + 1, indexDevided1);
                            continue;
                        }
                    }
                }
                else if (Index0 == "Renew")
                {
                    string index2 = cmdArgs[2];

                    if (inputInventory.Contains(index2))
                    {
                        inputInventory.Remove(index2);
                        inputInventory.Add(index2);
                    }
                }


            }

            Console.WriteLine(string.Join(", ",inputInventory));

        }
    }
}
