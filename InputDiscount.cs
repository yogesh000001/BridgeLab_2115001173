using System;

class Abc{
    public void discount(double amount, double discount){
        double discountAmount = amount * discount / 100;
        double finalAmount = amount - discountAmount;
        Console.WriteLine("Discount Amount: " + discountAmount);
        Console.WriteLine("Final Amount: " + finalAmount);  
    }
    public static void Main(string []args){
        Console.WriteLine("Enter the amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the discount percentage: ");
        double discount = Convert.ToDouble(Console.ReadLine());
        discount(amount, discount);
    }
}