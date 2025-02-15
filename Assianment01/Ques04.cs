using System;
using System.Text;
using System.Diagnostics;

class Program
{
    static void ComparePerformance(int iterations)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        string str = "";
        for (int i = 0; i < iterations; i++)
        {
            str += "Hello ";
        }
        stopwatch.Stop();
        Console.WriteLine("String Concatenation Time: " + stopwatch.ElapsedMilliseconds + " ms");

        stopwatch.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            sb.Append("Hello ");
        }
        stopwatch.Stop();
        Console.WriteLine("StringBuilder Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }

    static void Main()
    {
        Console.Write("Enter the number of iterations: ");
        int iterations = int.Parse(Console.ReadLine());
        ComparePerformance(iterations);
    }
}
