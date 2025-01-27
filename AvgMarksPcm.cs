using System;

class AvgMarksPcm
{
    // This method is calculating the average marks of PCM
    public static void AvgMarks()
    {
        int physics = 96;
        int chemistry = 96;
        int maths = 94;
        int avg = (physics + chemistry + maths) / 3;
        Console.WriteLine("Average marks of PCM is: " + avg);
    }
    public static void Main(string[] args)
    {
        
    }
}