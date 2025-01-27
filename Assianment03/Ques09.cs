using System;

class Program{
    // Function to calculate the power of a number
    public static void Power(int num,int pow){
        int result = 1;
        for(int i=0;i<pow;i++){
            result = result * num;
        }
        Console.WriteLine("The result is : "+result);
    }
    public static void Main(string[]args){
        Console.Write("Enter the number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the power : ");
        int pow = Convert.ToInt32(Console.ReadLine());
        Power(num,pow);
    }
}