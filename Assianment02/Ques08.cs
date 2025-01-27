using System;

class Program{
    // Function to find the greatest factor of the number
    public static void GreatestFactor(int num){
        int greatestFactor = 1;
        for(int i=num;i>=1;i--){
            if(num%i==0){
                greatestFactor = i;
                break;
            }
        }
        Console.WriteLine("The greatest factor of the number is : "+greatestFactor);
    }
    public static void Main(string[]args){
        Console.Write("Enter the number : ");
        int n = Convert.ToInt32(Console.ReadLine());
    }
}