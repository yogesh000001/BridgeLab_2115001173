using System;

class Program{
    public static void MinInThree(int num1, int num2, int num3){
        if(num1 < num2 && num1 < num3){
            Console.WriteLine("Is the first number the smallest number : "+num1);
        }
        else if(num2 < num1 && num2 < num3){
            Console.WriteLine("Is the first number the smallest number : "+num2);
        }
        else{
            Console.WriteLine("Is the first number the smallest number : "+num3);
        }
    } 
    public static void Main(string[]args){
        Console.WriteLine("Enter the number1 : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number2 : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number3 : ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        MinInThree(num1, num2, num3);
    }
}