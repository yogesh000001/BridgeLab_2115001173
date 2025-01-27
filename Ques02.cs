using System;

class Program{
    public static void func(int a,int b,int c){
        int operation1 = a + b * c;
        int operation2 = a * b + c;
        int operation3 = c + a / b;
        Console.WriteLine("The results of Int Operations are "+operation1+","+operation2+" and "+operation3);
    }
    
    public static void Main(string[]args){
        Console.WriteLine("Enter the number1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());    
        Console.WriteLine("Enter the number2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());    
        Console.WriteLine("Enter the number3: ");
        int num3 = Convert.ToInt32(Console.ReadLine());  
        func(num1,num2,num3);  
    }
}