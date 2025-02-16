using System;

class Program
{
    static int FindRotationPoint(int[] arr)
    {
        int left = 0, right = arr.Length - 1;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] > arr[right])
                left = mid + 1;
            else
                right = mid;
        }
        return left;
    }

    static void Main()
    {
        Console.Write("Enter array elements (comma-separated): ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
        int rotationIndex = FindRotationPoint(arr);
        Console.WriteLine($"The rotation point is at index: {rotationIndex}");
    }
}
