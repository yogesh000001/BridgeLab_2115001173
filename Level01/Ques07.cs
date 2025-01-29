using System;

class Program{
    //program to calculate the smallest and largest element among three numnbers
    public static int[] SmallestLargest(int num1,int num2,int num3){
        int sm = num1;
        int lr = num1;
        //for smaller elemet
        if(num2 < sm){
            sm = num2;
        }
        if(num3 < sm){
            sm = num3;
        }
        //for larger element
        if(num2>lr){
            lr = num2;
        }
        if(num3>lr){
            lr = num3;
        }
        return new int[]{sm,lr};
    }
    public static void Main(string []args){
        Console.Write("Enter the first number : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the third number : ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        int []arr = SmallestLargest(num1,num2,num3);
        Console.WriteLine("The smallest element is : "+arr[0]);
        Console.WriteLine("The largest element is : "+arr[1]);
    }
}