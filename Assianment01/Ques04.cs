using System;

class Program{
    public static void func(double []arr){
        double total = 0;
        int i = 0;
        while (true){
            double num = Convert.ToDouble(Console.ReadLine());
            i++;
            if (num == 0 || num < 0  || i == 10){
                break;
            }
            arr[i] = num;
        }
        for (int j = 0; j < arr.Length; j++){
            total += arr[j];
        }
        Console.WriteLine("Total is: " + total);
    }
    public static void Main(string[]args){
        double [] arr = new double[10];
        func(arr);
    }
}