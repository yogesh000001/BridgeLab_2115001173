using System;

class Abc{
    public static void discount(){
        double fee = 125000;
        double discount = 10;
        double DicountAmount = fee * discount / 100;
        double total = fee - DicountAmount;
        Console.WriteLine("The discount amount is INR "+DicountAmount +" and final discounted fee is INR "+total);
    }
    public static void Main(string []args){
        discount();
    }
}