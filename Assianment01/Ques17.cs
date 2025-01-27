using System;


class Program{
    public static void OddEven(int num){
        for(int i=1; i<=num; i++){
            if(i%2==0){
                Console.WriteLine(i+" is Even");
            }
            else{
                Console.WriteLine(i+" is Odd");
            }
        }
    }    
    public static void Main(string[]args){
        Console.WriteLine("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        OddEven(num);
    }
}
