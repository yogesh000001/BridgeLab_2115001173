using System;
using System.Collections.Generic;

// Abstract class Employee
abstract class Employee
{
    // Encapsulated fields with properties
    private int employeeId;
    private string name;
    protected double baseSalary;

    public int EmployeeId { get { return employeeId; } }
    public string Name { get { return name; } }

    // Constructor
    public Employee(int employeeId, string name, double baseSalary)
    {
        this.employeeId = employeeId;
        this.name = name;
        this.baseSalary = baseSalary;
    }

    // Abstract method to be implemented by subclasses
    public abstract double CalculateSalary();

    // Method to display employee details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Base Salary: " + baseSalary);
    }
}

// Interface for department management
interface IDepartment
{
    void AssignDepartment(string departmentName);
    string GetDepartmentDetails();
}

// Full-Time Employee subclass
class FullTimeEmployee : Employee, IDepartment
{
    private string department;

    // Constructor
    public FullTimeEmployee(int employeeId, string name, double baseSalary)
        : base(employeeId, name, baseSalary) { }

    // Implementing the abstract method
    public override double CalculateSalary()
    {
        return baseSalary;
    }

    // Implementing IDepartment methods
    public void AssignDepartment(string departmentName)
    {
        department = departmentName;
    }

    public string GetDepartmentDetails()
    {
        return "Full-Time Employee " + Name + " is in " + department + " department.";
    }

    // Overriding DisplayDetails
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Employee Type: Full-Time");
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Final Salary: " + CalculateSalary());
        Console.WriteLine("-------------------------");
    }
}

// Part-Time Employee subclass
class PartTimeEmployee : Employee, IDepartment
{
    private string department;
    private int workHours;
    private double hourlyRate;

    // Constructor
    public PartTimeEmployee(int employeeId, string name, double hourlyRate, int workHours)
        : base(employeeId, name, hourlyRate * workHours)
    {
        this.workHours = workHours;
        this.hourlyRate = hourlyRate;
    }

    // Implementing the abstract method
    public override double CalculateSalary()
    {
        return hourlyRate * workHours;
    }

    // Implementing IDepartment methods
    public void AssignDepartment(string departmentName)
    {
        department = departmentName;
    }

    public string GetDepartmentDetails()
    {
        return "Part-Time Employee " + Name + " is in " + department + " department.";
    }

    // Overriding DisplayDetails
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Employee Type: Part-Time");
        Console.WriteLine("Hourly Rate: " + hourlyRate);
        Console.WriteLine("Work Hours: " + workHours);
        Console.WriteLine("Final Salary: " + CalculateSalary());
        Console.WriteLine("Department: " + department);
        Console.WriteLine("-------------------------");
    }
}

// Main class to test the implementation
class Program
{
    static void Main()
    {
        // Creating a list of employees
        List<Employee> employees = new List<Employee>();

        // Creating objects
        FullTimeEmployee emp1 = new FullTimeEmployee(101, "Alice", 50000);
        PartTimeEmployee emp2 = new PartTimeEmployee(102, "Bob", 50, 120);

        // Assigning departments
        emp1.AssignDepartment("Finance");
        emp2.AssignDepartment("Marketing");

        // Adding to list
        employees.Add(emp1);
        employees.Add(emp2);

        //Displaying employee details
        foreach (var emp in employees)
        {
            emp.DisplayDetails();
        }
    }
}
