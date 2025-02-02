using System;

class MaxThree{
    //program to calculate max in between three number 
    public static void MaxOfThree(int num1,int num2,int num3){
        int max = num1;
        if(num2>max){
            max = num2;
        }
        if(num3>max){
            max = num3;
        }
        Console.WriteLine("The max out of three is : "+max);
    }
    public static void Main(string[] args){
        Console.Write("Enter first number : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number : ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        MaxOfThree(num1,num2,num3);
    }
}