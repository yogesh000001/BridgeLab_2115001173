using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();

        // Variables to manage the dynamic array
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        foreach (char c in input)
        {
            if (char.IsDigit(c)) 
            {
                if (index == maxDigit)
                {
                    maxDigit += 10;
                    int[] temp = new int[maxDigit]; 
                    for (int i = 0; i < digits.Length; i++);
                    {
                        temp[i] = digits[i];
                    }
                    digits = temp;
                }

                digits[index] = c - '0'; 
                index++;
            }
        }

        if (index < 2)
        {
            Console.WriteLine("Not enough digits to find the largest and second largest numbers.");
            return;
        }

        int largest = int.MinValue, secondLargest = int.MinValue;

        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine($"\nThe largest digit is: {largest}");
        Console.WriteLine($"The second-largest digit is: {secondLargest}");
    }
}
