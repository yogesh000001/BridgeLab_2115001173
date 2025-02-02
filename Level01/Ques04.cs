using System;

class Fibonacii{
    //program to print fibonacii series
    public static void FibonaciiSeries(int num){
        int f = 0;
        int s = 1;
        for(int i=0;i<num;i++){
            if(i<=1){
                Console.WriteLine(i);
                continue;
            }
            int ans = f + s;
            f = s;
            s = ans;
            Console.WriteLine(ans);
        }
    }
    public static void Main(string []args){
        Console.Write("Enter a number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        FibonaciiSeries(num);
    }
}