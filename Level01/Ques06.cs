using System;

class CarRental
{
    public string CustomerName { get; set; }
    public string CarModel { get; set; }
    public int RentalDays { get; set; }
    private const decimal DailyRate = 50.0m;

    public CarRental(string customerName, string carModel, int rentalDays)
    {
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;
    }

    public decimal CalculateTotalCost()
    {
        return RentalDays * DailyRate;
    }

    // Method to display rental details
    public void DisplayRentalDetails()
    {
        Console.WriteLine("Customer: " + CustomerName);
        Console.WriteLine("Car Model: " + CarModel);
        Console.WriteLine("Rental Days: " + RentalDays);
        Console.WriteLine("Total Cost: $" + CalculateTotalCost());
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Customer Name: ");
        string customerName = Console.ReadLine();

        Console.Write("Enter Car Model: ");
        string carModel = Console.ReadLine();

        Console.Write("Enter Rental Days: ");
        int rentalDays = int.Parse(Console.ReadLine());

        CarRental rental = new CarRental(customerName, carModel, rentalDays);
        Console.WriteLine("\nRental Details:");
        rental.DisplayRentalDetails();
    }
}
