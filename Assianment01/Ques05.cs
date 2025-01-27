using System;

class Program{
    public static void SumOfNaturalNumber(int num){
        if(num>0){
            int sum = num*(num+1)/2;
            Console.WriteLine("The sum of "+num+" natural number is : "+sum);
        }else{
            Console.WriteLine("The number "+num+" is not a natural number");
        }
    }
    public static void Main(string[]args){
        Console.WriteLine("Enter the number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        SumOfNaturalNumber(num);
    }
}