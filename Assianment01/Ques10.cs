using System;


class Program{


    public static void RocketCounter(int num){
        int temp = num;
        for(int i = 0; i < num; i++){
            Console.WriteLine(temp);
            temp--;
        }
    }
    public static void Main(string[]args){
        Console.WriteLine("Enter the number for counter : ");
        int num = Convert.ToInt32(Console.ReadLine());
        RocketCounter(num);
    }
}
