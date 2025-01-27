using System;


class Program{


    public static void func(double num){
        double total = 0;
        while (num!=0){
            total += num;
            num = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Total is: "+total);
    }
    public static void Main(string[]args){
        Console.WriteLine("Enter numbers to calculate total: ");
        double num = Convert.ToDouble(Console.ReadLine());
        func(num);
    }
}
