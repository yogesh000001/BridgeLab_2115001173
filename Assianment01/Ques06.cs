using System;

class Program{
    // Function to calculate the mean heigth of 11 players
    public static void MeanHeigth(double []arr){
        double sum = 0;
        for(int i=0;i<11;i++){
            sum += arr[i];
        }
        sum = sum/11;
        Console.WriteLine("Mean Heigth of 11 players is : "+sum);
    }
    public static void Main(string[]args){
        double []arr = new double[11];
        Console.WriteLine("Enter the heigth of 11 players : ");
        for(int i=0;i<11;i++){
            arr[i] = Convert.ToDouble(Console.ReadLine());
        }
        MeanHeigth(arr);
    }
}