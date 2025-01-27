using System;

class Program{
    // Function to print factor of a number
    public static void Factor(int num){
        int maxFactor = 10;
        int []arr = new int[maxFactor];
        int j = 0;
        for(int i=1;i<=num;i++){
            if(num%i==0){
                arr[j] = i;
                j++;
            }
        }
        Console.WriteLine("Even factors are : ");
        for(int i=0;i<j;i++){
            Console.Write(arr[i]+" ");
        }
    }
    public static void Main(string[]args){
        Console.Write("Enter a number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        Factor(num);
    }
}