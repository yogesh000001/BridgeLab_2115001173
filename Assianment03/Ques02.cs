using System;

class Program{
    // program to count the number of digits in a number
    public static void CountDigit(int num){
        int count = 0;
        while(num != 0){
            num = num/10;
            count++;
        }
        Console.WriteLine("The number of digits in the number is: "+count);
    }
    public static void Main(string[]args){
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        CountDigit(num);
    }
}