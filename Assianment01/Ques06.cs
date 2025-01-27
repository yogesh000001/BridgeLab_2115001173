using System;

class Program{
    public static void Voting(int age){
        if(age >= 18){
            Console.WriteLine("The person's age is "+age+" and can vote.");
        }else{
            Console.WriteLine("The person's age is "+age+" and cannot vote.");
        }
    }
    public static void Main(string[]args){
        Console.WriteLine("Enter the age : ");
        int age = Convert.ToInt32(Console.ReadLine());
        Voting(age);
    }
}