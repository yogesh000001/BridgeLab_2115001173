using System;

class MergeSort
{
    static void Merge(double[] arr, int left, int mid, int right)
    {
        int leftSize = mid - left + 1;
        int rightSize = right - mid;
        double[] leftArr = new double[leftSize];
        double[] rightArr = new double[rightSize];

        for (int i = 0; i < leftSize; i++)
            leftArr[i] = arr[left + i];
        for (int j = 0; j < rightSize; j++)
            rightArr[j] = arr[mid + 1 + j];

        int x = 0, y = 0, k = left;
        while (x < leftSize && y < rightSize)
        {
            if (leftArr[x] <= rightArr[y])
                arr[k++] = leftArr[x++];
            else
                arr[k++] = rightArr[y++];
        }
        while (x < leftSize)
            arr[k++] = leftArr[x++];
        while (y < rightSize)
            arr[k++] = rightArr[y++];
    }

    static void MergeSortAlgo(double[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSortAlgo(arr, left, mid);
            MergeSortAlgo(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    public static void Main(string []args)
    {
        double[] bookPrices = { 450.50, 120.99, 320.75, 500.00, 250.30 };
        MergeSortAlgo(bookPrices, 0, bookPrices.Length - 1);
        Console.WriteLine("Sorted Book Prices:");
        foreach (double price in bookPrices)
            Console.Write(price + " ");
    }
}
