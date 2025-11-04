using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        var register = new Register();

        while (true)
        {
            Console.Write("Ange ditt namn: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
                break;

            Console.WriteLine("Ange antal arbetade timmar: ");
            string hoursInput = Console.ReadLine();  
            if (!int.TryParse(hoursInput, out int workedHours))
            {
                Console.WriteLine("Fel inmatning av timmar!");
                continue;
            }  

            Console.WriteLine("Ange din timlön: ");
            string wageInput = Console.ReadLine();  
            if (!int.TryParse(wageInput, out int hourlyWage))
            {
                Console.WriteLine("Fel inmatning av timmar!");
                continue;
            }  
                var employee = new Employee(name, workedHours, hourlyWage);
                register.AddNewEmployee(employee);

                register.printEmployees(); 
        }

    }
}


