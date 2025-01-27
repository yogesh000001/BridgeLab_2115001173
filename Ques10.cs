using System;

class Program{
    public static void Choclates(int NumberOfStudent, int NumberOfChoclates){
        int NumberOfChoclatesPerStudent = NumberOfChoclates/NumberOfStudent;
        int RemainingChoclates = NumberOfChoclates%NumberOfStudent;
        Console.WriteLine("The number of chocolates each child gets is "+NumberOfChoclatesPerStudent+" and the number of remaining chocolates is "+RemainingChoclates);
    }
    public static void Main(string []args){
        Console.WriteLine("Enter the number of students: ");
        int NumberOfStudent = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of choclates: ");
        int NumberOfChoclates = Convert.ToInt32(Console.ReadLine());
        Choclates(NumberOfStudent, NumberOfChoclates);
    }
}