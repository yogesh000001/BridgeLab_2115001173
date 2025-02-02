using System;

class MaxThree{
    //program to check weather a number is prime or not 
    public static bool IsPrime(int num){
        for(int i=2;i<=num/2;i++){
            if(num%i==0){
                return false;
            }
        }
        return true;
    }
    public static void Main(string[] args){
        Console.WriteLine("Enter a number to check weather it is prime or not : ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (IsPrime(num))
        {
            Console.WriteLine(num+" is prime number");
        }else{
            Console.WriteLine(num+" is not a prime number");
        }
    }
}