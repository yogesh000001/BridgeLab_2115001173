using System;


class Program{
    public static void factorial(int num){
        int fact = 1;
        for(int i = 1; i <= num; i++){
            fact = fact * i;
        }
        Console.WriteLine("Factorial of {0} is {1}", num, fact);
    }    
    public static void Main(string[]args){
        Console.WriteLine("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        factorial(num);
    }
}
