using System;
// display the name, id and salary of the employee
public class Employee{
    private string name;
    private int id;
    private double salary;
    public Employee(string name,int id,double salary){
        this.name = name;
        this.id = id;
        this.salary = salary;
    }
    public void Display(){
        Console.WriteLine("The name of the employee is : "+name);
        Console.WriteLine("The id of the employee is : "+id);
        Console.WriteLine("The name salary of the employee is : "+salary);
    }
    public static void Main(string []args){
        Employee emp = new Employee("Yash",1,25400);
        emp.Display();
    }
}