using System;

class Program{

    public static void RocketCounter(int counter){
        while(counter>0){
            Console.WriteLine(counter);
            counter--;
        }
    }
    public static void Main(string[]args){
        Console.WriteLine("Enter the counter: ");
        int counter = Convert.ToInt32(Console.ReadLine());
        RocketCounter(counter);
    }
}