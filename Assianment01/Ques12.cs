using System;


class Program{
    public static void func(double num){
        double sum = 0;
        while(true){
            if(num == 0 || num < 0){
                break;
            }
            sum += num;
            num = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Sum of the numbers is : "+sum);
    }    
    public static void Main(string[]args){
        Console.WriteLine("Enter the number : ");
        double num = Convert.ToDouble(Console.ReadLine());
        func(num);
    }
}
