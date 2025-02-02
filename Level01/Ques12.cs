using System;

public class Employee
{
    public int employeeID;

    protected string department;

    private double salary;

    public Employee(int id, string dept, double initialSalary)
    {
        employeeID = id;
        department = dept;
        salary = initialSalary;
    }

    public void SetSalary(double newSalary)
    {
        if (newSalary >= 0)
        {
            salary = newSalary;
            Console.WriteLine($"Salary updated to: ${salary}");
        }
        else
        {
            Console.WriteLine("Invalid salary amount.");
        }
    }

    public double GetSalary()
    {
        return salary;
    }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Salary: $" + salary);
        Console.WriteLine();
    }
}

public class Manager : Employee
{
    public string teamSize; 

    public Manager(int id, string dept, double salary, string team)
        : base(id, dept, salary)
    {
        teamSize = team;
    }

    public void DisplayManagerDetails()
    {
        Console.WriteLine("Manager Details:");
        Console.WriteLine("Employee ID: " + employeeID); 
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Team Size: " + teamSize);
        Console.WriteLine("Salary (Accessed via GetSalary method): $" + GetSalary());
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new Employee(101, "IT", 60000);
        emp1.DisplayEmployeeDetails();

        emp1.SetSalary(65000);
        Console.WriteLine("Updated Salary: $" + emp1.GetSalary());
        Console.WriteLine();

        Manager manager1 = new Manager(201, "HR", 90000, "10 Employees");
        manager1.DisplayManagerDetails();
    }
}
