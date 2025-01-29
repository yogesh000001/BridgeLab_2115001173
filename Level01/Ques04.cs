using System;
class Program {
    //Detect number
    public static void DetectNumber(int num){
        if(num > 0){
            Console.WriteLine(1);
        }else if(num < 0){
            Console.WriteLine(-1);
        }else{
            Console.WriteLine(0);
        }
    }
    public static void Main(string[] args) {
        Console.Write("Enter a number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        DetectNumber(num);
    }
}