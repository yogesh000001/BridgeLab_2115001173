using System;

class Program
{
    static int FindFirstOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1, result = -1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
            {
                result = mid;
                right = mid - 1;
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return result;
    }

    static int FindLastOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1, result = -1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
            {
                result = mid;
                left = mid + 1;
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter sorted array elements (comma-separated): ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
        
        Console.Write("Enter target value: ");
        int target = int.Parse(Console.ReadLine());
        
        int first = FindFirstOccurrence(arr, target);
        int last = FindLastOccurrence(arr, target);
        
        Console.WriteLine(first != -1 ? $"First occurrence at index: {first}" : "Target not found");
        Console.WriteLine(last != -1 ? $"Last occurrence at index: {last}" : "Target not found");
    }
}
