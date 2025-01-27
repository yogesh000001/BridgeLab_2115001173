using System;

class Program{
    // program to check whether the number is Armstrong number or not
    public static void ArmstrongNumber(int num){
        int temp = num;
        int count = 0;
        int sum = 0;
        while(num>0){
            num = num/10;
            count++;
        }
        num = temp;
        while(num>0){
            int rem = num % 10;
            sum = sum + (int)Math.Pow(rem,count);
            num = num/10;
        }
        if(sum == temp){
            Console.WriteLine("The number is Armstrong Number");
        }
        else{
            Console.WriteLine("The number is not Armstrong Number");
        }
    }
    public static void Main(string[]args){
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        ArmstrongNumber(num);
    }
}