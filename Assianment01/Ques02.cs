using System;

class Program{
    // Function to check the positve and even or odd number
    public static void func(int []arr){
        for(int i=0;i<arr.Length;i++){
            if(arr[i]>0){
                if(arr[i]%2 == 0){
                    Console.WriteLine("The number "+arr[i]+" is even.");
                }
                else{
                    Console.WriteLine("The number "+arr[i]+" is odd.");
                }
            }
            else if (arr[i] == 0){
                Console.WriteLine("The number is Zero");
            }
            else
            {
                Console.WriteLine("The number is negative");
            }
        }
        if(arr[0] > arr[arr.Length-1]){
            Console.WriteLine("The first number is greater than the last number.");
        }else if(arr[0] > arr[arr.Length]){
            Console.WriteLine("The last number is greater than the first number.");
        }else{
            Console.WriteLine("The first and last number are equal.");
        }
    }
    public static void Main(string[]args){
        Console.WriteLine("Enter the number!");
        int []arr = new int[5];
        for(int i=0;i<5;i++){
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        func(arr);
    }
}