using System;

class Program{
    public static void totalIncome(double salary, double bonus){
        double totalIncome = salary + bonus;
        Console.WriteLine("The salary is INR "+salary+" and bonus is INR "+bonus+". Hence Total Income is INR "+totalIncome);
    }
    public static void Main(string[]args){
        Console.WriteLine("Enter the salary : ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the bonus : ");
        double bonus = Convert.ToDouble(Console.ReadLine());
        totalIncome(salary, bonus);
    }
}