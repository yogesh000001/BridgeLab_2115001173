using System;

class ZaraBonus
{
    // Method to generate random salary and years of service
    static int[,] GenerateEmployeeData(int numEmployees)
    {
        Random rand = new Random();
        int[,] employeeData = new int[numEmployees, 2]; // Column 1: Salary, Column 2: Years of service

        for (int i = 0; i < numEmployees; i++)
        {
            employeeData[i, 0] = rand.Next(30000, 99999); // Random salary between 30000 and 99999
            employeeData[i, 1] = rand.Next(1, 21); // Random years of service between 1 and 20
        }

        return employeeData;
    }

    // Method to calculate the new salary and bonus based on the years of service
    static double[,] CalculateBonusAndNewSalary(int[,] employeeData, int numEmployees)
    {
        double[,] salaryAndBonus = new double[numEmployees, 2]; // Column 1: New salary, Column 2: Bonus amount

        for (int i = 0; i < numEmployees; i++)
        {
            double bonus = 0;
            if (employeeData[i, 1] >= 5)
            {
                bonus = employeeData[i, 0] * 0.05; // 5% bonus
            }
            else
            {
                bonus = employeeData[i, 0] * 0.02; // 2% bonus
            }

            double newSalary = employeeData[i, 0] + bonus;
            salaryAndBonus[i, 0] = newSalary;
            salaryAndBonus[i, 1] = bonus;
        }

        return salaryAndBonus;
    }

    // Method to calculate the total old salary, total new salary, and total bonus
    static void CalculateTotals(int[,] employeeData, double[,] salaryAndBonus, int numEmployees)
    {
        double totalOldSalary = 0, totalNewSalary = 0, totalBonus = 0;

        Console.WriteLine("Employee No.\tOld Salary\tYears of Service\tBonus\tNew Salary");

        for (int i = 0; i < numEmployees; i++)
        {
            double oldSalary = employeeData[i, 0];
            double newSalary = salaryAndBonus[i, 0];
            double bonus = salaryAndBonus[i, 1];
            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            Console.WriteLine($"{i + 1}\t\t{oldSalary}\t\t{employeeData[i, 1]}\t\t{bonus}\t{newSalary}");
        }

        Console.WriteLine("\nTotal Old Salary: " + totalOldSalary);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
        Console.WriteLine("Total Bonus: " + totalBonus);
    }

    static void Main()
    {
        int numEmployees = 10; // Number of employees
        int[,] employeeData = GenerateEmployeeData(numEmployees);
        double[,] salaryAndBonus = CalculateBonusAndNewSalary(employeeData, numEmployees);
        CalculateTotals(employeeData, salaryAndBonus, numEmployees);
    }
}
