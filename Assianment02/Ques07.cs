using System;

class Program{
    // Function to fing the oldest and tallest person
    public static void AgeHeight(int ageAmar,double heightAmar,int ageAkbar,double heightAkbar,int ageAnthony,double heightAnthony){
        if (ageAmar > ageAkbar && ageAmar > ageAnthony){
            Console.WriteLine("Amar is the oldest");
        }
        else if (ageAkbar > ageAmar && ageAkbar > ageAnthony){
            Console.WriteLine("Akbar is the oldest");
        }
        else if (ageAnthony > ageAmar && ageAnthony > ageAkbar){
            Console.WriteLine("Anthony is the oldest");
        }
        else{
            Console.WriteLine("All are of same age");
        }
        if (heightAmar > heightAkbar && heightAmar > heightAnthony){
            Console.WriteLine("Amar is the tallest");
        }
        else if (heightAkbar > heightAmar && heightAkbar > heightAnthony){
            Console.WriteLine("Akbar is the tallest");
        }
        else if (heightAnthony > heightAmar && heightAnthony > heightAkbar){
            Console.WriteLine("Anthony is the tallest");
        }
        else{
            Console.WriteLine("All are of same height");
        }
        
    }
    public static void Main(string[]args){
        Console.Write("Enter the age of Amar: ");
        int ageAmar = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the heigth of Amar: ");
        double heightAmar = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the age of Akbar: ");
        int ageAkbar = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the heigth of Akbar: ");
        double heightAkbar = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the age of Anthony: ");
        int ageAnthony = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the heigth of Anthony: ");
        double heightAnthony = Convert.ToDouble(Console.ReadLine());
        AgeHeight(ageAmar, heightAmar, ageAkbar, heightAkbar, ageAnthony, heightAnthony);
    }
}