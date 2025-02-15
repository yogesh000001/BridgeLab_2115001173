using System;

class QuickSort
{
    public static void Sort(int[] prices, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(prices, left, right);
            Sort(prices, left, pivotIndex - 1);
            Sort(prices, pivotIndex + 1, right);
        }
    }

    private static int Partition(int[] prices, int left, int right)
    {
        int pivot = prices[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (prices[j] < pivot)
            {
                i++;
                Swap(prices, i, j);
            }
        }

        Swap(prices, i + 1, right);
        return i + 1;
    }

    private static void Swap(int[] prices, int a, int b)
    {
        int temp = prices[a];
        prices[a] = prices[b];
        prices[b] = temp;
    }

    public static void Main(string []args)
    {
        int[] productPrices = { 300, 100, 400, 200, 500 };
        Console.WriteLine("Original Prices: " + string.Join(", ", productPrices));

        Sort(productPrices, 0, productPrices.Length - 1);

        Console.WriteLine("Sorted Prices: " + string.Join(", ", productPrices));
    }
}
