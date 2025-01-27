using System;

class Program{
    // Function to print fizz buzz
    public static void FizzBuzz(int num){
        string []arr = new string[num+1];
        for(int i=0;i<num;i++){
            if((i+1)%3 == 0 && (i+1)%5 == 0){
                arr[i] = "FizzBuzz";
            }else if((i+1)%3 == 0){
                arr[i] = "Fizz";
            }else if((i+1)%5 == 0){
                arr[i] = "Buzz";
            }else{
                arr[i] = (i+1).ToString();
            }
        }
        for(int i=0;i<num;i++){
            Console.WriteLine(i+1+" = "+arr[i]);
        }
    }
    public static void Main(string[]args){
        Console.Write("Enter the number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0){
            FizzBuzz(num);
        }else{
            Console.WriteLine("Enter a positive number");
        }
    }
}