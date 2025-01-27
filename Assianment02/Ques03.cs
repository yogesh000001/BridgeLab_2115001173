using System;

class Program{
    // Function to check weather a number is prime or not
    public static void isPrime(int num){
        bool flag = false;
        for(int i=2; i<=num/2; i++){
            if(num%i == 0){
                flag = true;
                break;
            }
        }
        if(!flag){
            Console.WriteLine(num + " is a prime number");
        }else{
            Console.WriteLine(num + " is not a prime number");
        } 
    }
    public static void Main(string[]args){
        Console.Write("Enter a number to check weather it is prime or not : ");
        int num = Convert.ToInt32(Console.ReadLine());
        isPrime(num);
    }
}