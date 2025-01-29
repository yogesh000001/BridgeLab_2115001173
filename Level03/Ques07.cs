using System;

class CollinearPoints
{
    // Method to calculate the slope between two points
    static double CalculateSlope(int x1, int y1, int x2, int y2)
    {
        return (double)(y2 - y1) / (x2 - x1);
    }

    // Method to check if the points are collinear using the slope formula
    static bool AreCollinearUsingSlope(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        // Calculate slopes
        double slopeAB = CalculateSlope(x1, y1, x2, y2);
        double slopeBC = CalculateSlope(x2, y2, x3, y3);
        double slopeAC = CalculateSlope(x1, y1, x3, y3);

        // If slopes are equal, points are collinear
        return (slopeAB == slopeBC && slopeAB == slopeAC);
    }

    // Method to check if the points are collinear using the area of the triangle formula
    static bool AreCollinearUsingArea(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        // Calculate the area of the triangle formed by the points
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

        // If area is zero, points are collinear
        return area == 0;
    }

    static void Main()
    {
        // Input coordinates of three points
        Console.Write("Enter coordinates of point A (x1, y1): ");
        string[] inputA = Console.ReadLine().Split(',');
        int x1 = int.Parse(inputA[0].Trim());
        int y1 = int.Parse(inputA[1].Trim());

        Console.Write("Enter coordinates of point B (x2, y2): ");
        string[] inputB = Console.ReadLine().Split(',');
        int x2 = int.Parse(inputB[0].Trim());
        int y2 = int.Parse(inputB[1].Trim());

        Console.Write("Enter coordinates of point C (x3, y3): ");
        string[] inputC = Console.ReadLine().Split(',');
        int x3 = int.Parse(inputC[0].Trim());
        int y3 = int.Parse(inputC[1].Trim());

        // Check if points are collinear using the slope formula
        bool collinearBySlope = AreCollinearUsingSlope(x1, y1, x2, y2, x3, y3);
        if (collinearBySlope)
        {
            Console.WriteLine("Points are collinear (using slope formula).");
        }
        else
        {
            Console.WriteLine("Points are NOT collinear (using slope formula).");
        }

        // Check if points are collinear using the area of triangle formula
        bool collinearByArea = AreCollinearUsingArea(x1, y1, x2, y2, x3, y3);
        if (collinearByArea)
        {
            Console.WriteLine("Points are collinear (using area formula).");
        }
        else
        {
            Console.WriteLine("Points are NOT collinear (using area formula).");
        }
    }
}
