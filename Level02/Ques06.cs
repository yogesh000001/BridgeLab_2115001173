using System;

class Factorial{
    public static long CalculateFactorial(int num){
        if(num == 0 || num == 1){
            return 1;
        }   
        return num * CalculateFactorial(num-1);
    }
    public static void Main(string []args){
        Console.Write("Enter a numeber : ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The factorial of "+num+" is : "+CalculateFactorial(num));
    }
}