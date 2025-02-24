using System;

class Program
{
    static void Main()
    {
        string cardNumber = Console.ReadLine();
        if ((cardNumber.Length == 16 && cardNumber[0] == '4') || (cardNumber.Length == 16 && cardNumber[0] == '5'))
        {
            Console.WriteLine("Valid Card");
        }
        else
        {
            Console.WriteLine("Invalid Card");
        }
    }
}
