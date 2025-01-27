using System;

class ProfitLossPercentage
{
    public static void calculateCostPrice()
    {
        float CostPrice = 129;
        float SellingPrice = 191;
        float Profit = SellingPrice - CostPrice;
        float ProfitPercentage = (Profit / CostPrice) * 100;
        Console.WriteLine("The Cost Price in INR "+CostPrice+" and selling Price in INR "+SellingPrice);
        Console.WriteLine("The Profit in INR "+Profit+" and Profit Percentage is "+ProfitPercentage+"%");
    }
    public static void Main(string []args){
        calculateCostPrice();
    }
}