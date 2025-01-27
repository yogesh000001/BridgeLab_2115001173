using System;

class Program{
    // Function to copy 2D to 1D
    public static void Copy2DTo1D(int [,]arr,int row,int col){
        int []arr1D = new int[row*col];
        int k = 0;
        for(int i=0; i<arr.GetLength(0); i++){
            for(int j=0; j<arr.GetLength(1); j++){
                arr1D[k] = arr[i,j];
                k++;
            }
        }
    }
    public static void Main(string[]args){
        Console.Write("Enter the rows of 2D array : ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the columns of 2D array : ");
        int cols = Convert.ToInt32(Console.ReadLine());
        int [,]arr = new int[row, col];
        Console.WriteLine("Enter the elements of 2D array : ");
        for(int i=0; i<rows; i++){
            for(int j=0; j<cols; j++){
                arr[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}