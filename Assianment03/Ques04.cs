using System;

class Program{
    // program to find the abundent number
    public static void AbundantNumber(int num){
        int sum = 0;
        for(int i = 1; i <= num/2; i++){
            if(num % i == 0){
                sum += i;
            }
        }
        if(sum > num){
            Console.WriteLine("The number is Abundant Number");
        }
        else{
            Console.WriteLine("The number is not Abundant Number");
        }
    }
    public static void Main(string[]args){
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        AbundantNumber(num);
    }
}