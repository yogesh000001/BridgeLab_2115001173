using System;

class Program{
    public static void DivibleByFive(int num){
        if(num%5==0){
            Console.WriteLine("Is the number "+num+" divisible by 5");
        }
        else{
            Console.WriteLine("Is the number "+num+" not divisible by 5");
        }
    }
    public static void Main(string[]args){
        Console.WriteLine("Enter the number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        DivibleByFive(num);
    }
}