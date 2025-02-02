using System;

class HotelBooking
{
    // Properties
    public string GuestName { get; set; }
    public string RoomType { get; set; }
    public int Nights { get; set; }

    // Default Constructor
    public HotelBooking()
    {
        GuestName = "Unknown Guest";
        RoomType = "Standard";
        Nights = 1;
    }

    // Parameterized Constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        GuestName = guestName;
        RoomType = roomType;
        Nights = nights;
    }

    // Copy Constructor (Cloning another booking)
    public HotelBooking(HotelBooking other)
    {
        GuestName = other.GuestName;
        RoomType = other.RoomType;
        Nights = other.Nights;
    }

    // Method to Display Booking Details
    public void DisplayBooking()
    {
        Console.WriteLine("Guest Name: "+GuestName);
        Console.WriteLine("Room Type: "+RoomType);
        Console.WriteLine("Nights: "+Nights);
    }


    // Main Method to Test the Class
    public static void Main(string []args)
    {
        // Using Default Constructor
        HotelBooking booking1 = new HotelBooking();
        Console.WriteLine("Booking 1 Details:");
        booking1.DisplayBooking();
        Console.WriteLine();

        // Using Parameterized Constructor
        HotelBooking booking2 = new HotelBooking("Alice Johnson", "Suite", 3);
        Console.WriteLine("Booking 2 Details:");
        booking2.DisplayBooking();
        Console.WriteLine();

        // Using Copy Constructor
        HotelBooking booking3 = new HotelBooking(booking2);
        Console.WriteLine("Copied Booking (Booking 3) Details:");
        booking3.DisplayBooking();
    }
}
