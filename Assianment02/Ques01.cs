using System;

class Program{
    // Program to find weather a year is leap year or not
    public static void IsLeapYear(int num){
        if ((num % 4 == 0 && num % 100 != 0) || (num % 400 == 0)){
            Console.WriteLine(num +" is a Leap Year");
        }
        else{
            Console.WriteLine(num +" Not a Leap Year");
        }
    }
    public static void Main(string[]args){
        Console.Write("Enter the year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        IsLeapYear(year);
    }
}