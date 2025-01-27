using System;


class Program{
    public static void factorial(int num){
        int fact=1;
        while(num>0){
            fact=fact*num;
            num = num-1;
        }
        Console.WriteLine("Factorial is: "+fact);
    }    
    public static void Main(string[]args){
        Console.WriteLine("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        factorial(num);
    }
}
