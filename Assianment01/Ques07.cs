using System;

class Program{
    // Function to print odd even in different arrays
    public static void EvenOdd(int num){
        int oddIndex = 0;
        int evenIndex = 0;
        int size = (num/2);
        int []evenArray = new int[size];
        int []oddArray = new int[size];
        for(int i=1;i<=num;i++){
            if(i%2 == 0){
                evenArray[evenIndex] = i;
                evenIndex++;
            }else{
                oddArray[oddIndex] = i;
                oddIndex++;
            }
        }
        int even = 0;
        int odd = 0;
        Console.WriteLine("Even Array!");
        while(even < evenArray.Length){
            Console.WriteLine(evenArray[even]);
            even++;
        }
        Console.WriteLine("Odd Array!");
        while(odd < oddArray.Length){
            Console.WriteLine(oddArray[odd]);
            odd++;
        }
    }
    public static void Main(string[]args){
        Console.Write("Enter a natural number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0){
            EvenOdd(num);
        }else{
            Console.WriteLine("Please enter a natural number");
        }
    }
}