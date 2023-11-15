using System;
using System.Globalization;
using Primeiro.Entities;

namespace Primeiro
{
    class Program
    {
       static void Main()
        { 
            List<Employee> list = new List<Employee>();

            // entradas de dados  
            Console.Write("Enter the number employye: "); 
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} Data:"); 
                Console.Write("Outdsource (y/n)? "); 
                char cha = char.Parse(Console.ReadLine());
                Console.Write("Name: "); 
                string name = Console.ReadLine();
                Console.Write("Hours: "); 
                int hours = int.Parse(Console.ReadLine());
                Console.Write("value per hour: "); 
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                if (cha == 'y')
                {
                   Console.Write("Additional charge: "); 
                   double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
                   list.Add( new OutsorcedEmployee(name, hours, valuePerHour, additionalCharge));  
                   Console.WriteLine();                  
                }
                else 
                {
                   list.Add(new Employee(name, hours, valuePerHour));   
                }
            }
            // saida de dados 

            Console.WriteLine(); 
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee prop in list)
            {
                Console.WriteLine($" {prop.Name} - $ {prop.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine();
            } 
        }
    }
}

