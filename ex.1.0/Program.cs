using System;

namespace ex._1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sumWithoutTax = 0;


            while (command != "special" && command != "regular")
            {
              //if 
                double commande = 0;
                double.TryParse(command,out commande);

                if (commande < 0)
                {
                    Console.WriteLine("Invalid price!");
                    commande = 0;
                }

                sumWithoutTax += commande;
                //Console.WriteLine($"{sumWithoutTax}");
                command = Console.ReadLine();
            }
            
            double taxes = sumWithoutTax * 0.20;
            double sumWithTaxes = sumWithoutTax + taxes;
            if (sumWithTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                if (command == "special")
                {
                    sumWithTaxes = sumWithTaxes - sumWithTaxes * 0.10;

                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {sumWithoutTax:f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {sumWithTaxes:f2}$");
                }
                else
                {
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {sumWithoutTax:f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {sumWithTaxes:f2}$");
                }
            } 
        }
    }
}
