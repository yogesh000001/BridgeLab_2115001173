using System;

class Program{
    // program to find the harshad number
    public static void HarshadNumber(int num){
        int sum = 0;
        while(num != 0){
            int rem = num % 10;
            sum += rem;
            num /= 10;
        }
        if(sum%3 == 0){
            Console.WriteLine("The number is Harshad number");
        }
        else{
            Console.WriteLine("The number is not Harshad number");          
        }
    }
    public static void Main(string[]args){
        Console.Write("Enter the number to check weather it Harshad number or not : ");
        int num = Convert.ToInt32(Console.ReadLine());
        HarshadNumber(num);
    }
}