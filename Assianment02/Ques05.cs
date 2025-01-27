using System;

class Program{
    // Function to print FizzBuzz uding while loop
    public static void FizzBuzz(int num){
        int i = 1;
        while(i<=num){
            if(i%3==0 && i%5==0){
                Console.WriteLine("FizzBuzz");
            }
            else if(i%3==0){
                Console.WriteLine("Fizz");
            }
            else if(i%5==0){
                Console.WriteLine("Buzz");
            }
            else{
                Console.WriteLine(i);
            }
            i++;
        }
    }
    public static void Main(string[]args){
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        FizzBuzz(num);
    }
}