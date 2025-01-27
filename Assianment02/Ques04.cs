using System;

class Program{
    // Function to print FizzBuzz
    public static void FizzBuzz(int num){
        for(int i=1; i<=num; i++){
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
        }
    }
    public static void Main(string[]args){
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        FizzBuzz(num);
    }
}