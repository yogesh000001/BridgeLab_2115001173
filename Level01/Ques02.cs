using System;

class Program
{
    //program to reverse string
    static string ReverseString(string input){
        char[] charArray = new char[input.Length];
        int i = 0;
        int j = input.Length - 1;

        while (j >= 0)
        {
            charArray[i] = input[j];
            i++;
            j--;
        }
  
        return new string(charArray);
    }

    public static void Main(string []args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        string reverse = ReverseString(input);
        Console.WriteLine("Reversed string: " + reverse);
    }
}
