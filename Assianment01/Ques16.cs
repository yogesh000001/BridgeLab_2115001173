using System;

class Program
{
    static int FindFirstMissingPositive(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            while (arr[i] > 0 && arr[i] <= n && arr[arr[i] - 1] != arr[i])
            {
                int temp = arr[i];
                arr[i] = arr[temp - 1];
                arr[temp - 1] = temp;
            }
        }
        
        for (int i = 0; i < n; i++)
        {
            if (arr[i] != i + 1)
                return i + 1;
        }
        return n + 1;
    }

    static void Main()
    {
        Console.Write("Enter array elements (comma-separated): ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
        
        int missing = FindFirstMissingPositive(arr);
        Console.WriteLine($"The first missing positive integer is: {missing}");
    }
}
