using System;

class Program{
    // Function to find the multiple of a number in between 1 to 100
    public static void MultipleOfNumber(int num){
        for(int i=100;i>=1;i--){
            if(num%i == 0){
                Console.WriteLine(i);
            }else{
                continue;
            }
        }
    }
    public static void Main(string[]args){
        Console.Write("Enter a number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        MultipleOfNumber(num);
    }
}