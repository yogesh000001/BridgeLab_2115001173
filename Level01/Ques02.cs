using System;

class HandShake
{
    //program to calculate the max hand shake
    public static void HandShakeCount(int n)
    {
        int HandShake = n * (n - 1) / 2;
        Console.WriteLine("The number of handshakes is " + HandShake);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of students : ");
        int n = Convert.ToInt32(Console.ReadLine());
        HandShakeCount(n);
    }
}