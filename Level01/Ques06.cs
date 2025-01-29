using System;


class Program{
    //Program to find the sum of natural number
    public static void SumOfNaturalNumber(int num){
        int sum = 0;
        for(int i=1;i<=num;i++){
            sum += i;
        }
        Console.Write("The sum of natural number is : "+sum);
    }
    public static void Main(string[]args){
        Console.Write("Enter a number to find the sum of natural number : ")
        int num = Convert.ToInt32(Console.ReadLine());
        SumOfNaturalNumber(num);
    }
}
