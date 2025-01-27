using System;

class Program{
    // calculator function using switch statement
    public static void Calculator(double first,double second,string op){
        switch (op)
        {
            case "+":
                Console.WriteLine("The result is : " + (first + second));
                break;
            case "-":
                Console.WriteLine("The result is : " + (first - second));
                break;  
            case "*":
                Console.WriteLine("The result is : " + (first * second));
                break;
            case "/":
                Console.WriteLine("The result is : " + (first / second));
                break;
            default:
                return null;
        }
    }
    public static void Main(string []args){
        Console.Write("Enter the first value : ");
        double first = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second value : ");
        double second = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the operation : ");
        string op = Console.ReadLine();
        if (op == "+" || op == "-" || op == "*" || op == "/"){
            Calculator(first,second,op);    
        }else{
            Console.WriteLine("Enter valid operation")
        }
    }
}