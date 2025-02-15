using System;

class CountingSortAges
{
    static void CountingSort(int[] ages, int minAge, int maxAge)
    {
        int range = maxAge - minAge + 1;
        int[] count = new int[range];
        int[] output = new int[ages.Length];

        foreach (int age in ages)
            count[age - minAge]++;

        for (int i = 1; i < range; i++)
            count[i] += count[i - 1];

        for (int i = ages.Length - 1; i >= 0; i--)
        {
            output[count[ages[i] - minAge] - 1] = ages[i];
            count[ages[i] - minAge]--;
        }

        Array.Copy(output, ages, ages.Length);
    }

    public static void Main(string []args)
    {
        int[] studentAges = { 15, 12, 14, 13, 16, 18, 11, 10, 17, 12, 14, 15 };
        int minAge = 10, maxAge = 18;
        CountingSort(studentAges, minAge, maxAge);
        Console.WriteLine(string.Join(", ", studentAges));
    }
}
