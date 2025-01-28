using System;

class Program
{
    static void Main()
    {
        const int numEmployees = 10;
        double[] salaries = new double[numEmployees];
        double[] yearsOfService = new double[numEmployees];
        double[] bonuses = new double[numEmployees];
        double[] newSalaries = new double[numEmployees];

        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;

        for (int i = 0; i < numEmployees; i++)
        {
            while (true)
            {
                Console.WriteLine($"Enter salary for employee {i + 1}:");
                if (double.TryParse(Console.ReadLine(), out salaries[i]) && salaries[i] > 0)
                    break;
                else
                    Console.WriteLine("Invalid salary. Please enter a valid positive number.");
            }

            while (true)
            {
                Console.WriteLine($"Enter years of service for employee {i + 1}:");
                if (double.TryParse(Console.ReadLine(), out yearsOfService[i]) && yearsOfService[i] >= 0)
                    break;
                else
                    Console.WriteLine("Invalid years of service. Please enter a valid number.");
            }
        }

        for (int i = 0; i < numEmployees; i++)
        {
            if (yearsOfService[i] > 5)
            {
                bonuses[i] = salaries[i] * 0.05;
            }
            else
            {
                bonuses[i] = salaries[i] * 0.02;
            }

            
            newSalaries[i] = salaries[i] + bonuses[i];

            
            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }

        
        Console.WriteLine("\nSummary of Bonuses and Salaries:");
        for (int i = 0; i < numEmployees; i++)
        {
            Console.WriteLine($"Employee {i + 1}:");
            Console.WriteLine($"Old Salary: {salaries[i]:C2}");
            Console.WriteLine($"Bonus: {bonuses[i]:C2}");
            Console.WriteLine($"New Salary: {newSalaries[i]:C2}");
            Console.WriteLine();
        }

        Console.WriteLine($"Total Bonus Paid: {totalBonus:C2}");
        Console.WriteLine($"Total Old Salary: {totalOldSalary:C2}");
        Console.WriteLine($"Total New Salary: {totalNewSalary:C2}");
    }
}
