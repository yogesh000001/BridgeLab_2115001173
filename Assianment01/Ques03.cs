using System;
using System.Collections.Generic;

abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    protected double rentalRate;

    public string VehicleNumber { get { return vehicleNumber; } }
    public string Type { get { return type; } }

    public Vehicle(string vehicleNumber, string type, double rentalRate)
    {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
    }

    public abstract double CalculateRentalCost(int days);

    public virtual void ShowDetails(int days)
    {
        Console.WriteLine("Vehicle Number: " + vehicleNumber);
        Console.WriteLine("Type: " + type);
        Console.WriteLine("Rental Cost for " + days + " days: " + CalculateRentalCost(days));
    }
}

interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

class Car : Vehicle, IInsurable
{
    private string policyNumber;
    private double insuranceRate = 0.02;

    public Car(string vehicleNumber, double rentalRate, string policyNumber) : base(vehicleNumber, "Car", rentalRate)
    {
        this.policyNumber = policyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }

    public double CalculateInsurance()
    {
        return rentalRate * insuranceRate;
    }

    public string GetInsuranceDetails()
    {
        return "Car insurance rate: " + (insuranceRate * 100) + "%";
    }

    public override void ShowDetails(int days)
    {
        base.ShowDetails(days);
        Console.WriteLine(GetInsuranceDetails());
        Console.WriteLine("Insurance Cost: " + CalculateInsurance());
        Console.WriteLine("Total Cost: " + (CalculateRentalCost(days) + CalculateInsurance()));
        Console.WriteLine("-----------------------------");
    }
}

class Bike : Vehicle
{
    public Bike(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Bike", rentalRate) { }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }

    public override void ShowDetails(int days)
    {
        base.ShowDetails(days);
        Console.WriteLine("Total Cost: " + CalculateRentalCost(days));
        Console.WriteLine("-----------------------------");
    }
}

class Truck : Vehicle, IInsurable
{
    private string policyNumber;
    private double insuranceRate = 0.05;

    public Truck(string vehicleNumber, double rentalRate, string policyNumber) : base(vehicleNumber, "Truck", rentalRate)
    {
        this.policyNumber = policyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }

    public double CalculateInsurance()
    {
        return rentalRate * insuranceRate;
    }

    public string GetInsuranceDetails()
    {
        return "Truck insurance rate: " + (insuranceRate * 100) + "%";
    }

    public override void ShowDetails(int days)
    {
        base.ShowDetails(days);
        Console.WriteLine(GetInsuranceDetails());
        Console.WriteLine("Insurance Cost: " + CalculateInsurance());
        Console.WriteLine("Total Cost: " + (CalculateRentalCost(days) + CalculateInsurance()));
        Console.WriteLine("-----------------------------");
    }
}

class RentalSystem
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("C123", 1000, "POL001"),
            new Bike("B456", 300),
            new Truck("T789", 2000, "POL002")
        };

        int days = 5;
        foreach (var v in vehicles)
        {
            v.ShowDetails(days);
        }
    }
}
