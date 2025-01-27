using System;


class Program{
    public static void sum(int num){
        int temp = num;
        int sum = 0;
        while(temp>0){
            sum += temp;
            temp--;
        }
        int fsum = num * (num+1)/2;
        if(sum == fsum){
            Console.WriteLine("The sum of first "+num+" natural numbers is : "+sum);
        }
        else{
            Console.WriteLine("The sum of first "+num+" natural numbers is : "+sum);
            Console.WriteLine("The formula sum of first "+num+" natural numbers is : "+fsum);
        }
    }    
    public static void Main(string[]args){
        Console.WriteLine("Enter the number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0){
            sum(num);
        }
        else{
            Console.WriteLine("Please enter a natural number");
        }
    }
}
