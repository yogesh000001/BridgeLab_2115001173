using System;


class Program{
    public static void BonusAmount(double amount,int year){
        if(year>5){
            Console.WriteLine("The bonus amount is: "+amount*0.05);
        }
        else{
            Console.WriteLine("The bonus amount is: "+0);
        }
        
    }    
    public static void Main(string[]args){
        Console.WriteLine("Enter the amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the year of expreince: ");
        int year = Convert.ToInt32(Console.ReadLine());
        BonusAmount(amount,year);
    }
}
