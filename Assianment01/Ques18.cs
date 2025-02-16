using System;

class Program
{
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }

    static void Main()
    {
        Console.Write("Enter array elements (comma-separated): ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
        Array.Sort(arr);
        
        Console.Write("Enter target value: ");
        int target = int.Parse(Console.ReadLine());
        
        int index = BinarySearch(arr, target);
        Console.WriteLine(index != -1 ? $"Target found at index: {index}" : "Target not found");
    }
}
