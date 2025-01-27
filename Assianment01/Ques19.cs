using System;


class Program{
    public static void Table(int num){
        int number = 1;
        for(int i=1;i<=10;i++){
            Console.WriteLine(num+" * "+number+" = "+num*number);
            number++;
        }
    }    
    public static void Main(string[]args){
        Console.WriteLine("Enter the number in between 6 to 9 for finding table : ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num>=6 && num<=9){
            Table(num);
        }
        else{
            Console.WriteLine("Please enter the number in between 6 to 9");
        }
    }
}
