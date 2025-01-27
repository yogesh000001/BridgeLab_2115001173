using System;

class Program{
    //Program to detect the number is positive, negative or zero
    public static void NumberDetect(int num){
        if(num>0){
            Console.WriteLine("Positive");
        }else if(num<0){
            Console.WriteLine("Negative");
        }else{ 
            Console.WriteLine("Zero");
        }
    }
    public static void Main(string[]args){
        Console.WriteLine("Enter the number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        NumberDetect(num);
    }
}