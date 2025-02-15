using System;

class Program
{
    static int FindPeakElement(int[] arr)
    {
        int left = 0, right = arr.Length - 1;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] > arr[mid + 1])
                right = mid;
            else
                left = mid + 1;
        }
        return left;
    }

    static void Main()
    {
        Console.Write("Enter array elements (comma-separated): ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
        int peakIndex = FindPeakElement(arr);
        Console.WriteLine($"A peak element is at index: {peakIndex}");
    }
}
