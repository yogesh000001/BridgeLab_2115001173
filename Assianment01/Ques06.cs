using System;

class HeapSort
{
    public void Sort(int[] array)
    {
        int n = array.Length;
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(array, n, i);
        for (int i = n - 1; i > 0; i--)
        {
            (array[0], array[i]) = (array[i], array[0]);
            Heapify(array, i, 0);
        }
    }

    void Heapify(int[] array, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        if (left < n && array[left] > array[largest])
            largest = left;
        if (right < n && array[right] > array[largest])
            largest = right;
        if (largest != i)
        {
            (array[i], array[largest]) = (array[largest], array[i]);
            Heapify(array, n, largest);
        }
    }

    public static void Main(string []args)
    {
        int[] salaries = { 50000, 70000, 40000, 90000, 60000, 30000 };
        HeapSort sorter = new HeapSort();
        sorter.Sort(salaries);
        Console.WriteLine(string.Join(" ", salaries));
    }
}