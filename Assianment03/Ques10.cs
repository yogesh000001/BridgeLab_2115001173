using System;

class Program{
    // Function to find the factors of a number
    public static void FactorsOfNumber(int num){
        for(int i=1;i<=num/2;i++){
            if(num%i==0){
                Console.Write(i+" ");
            }
        }
    }
    public static void Main(string[]args){
        Console.Write("Enter the number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        FactorsOfNumber(num);
    }
}