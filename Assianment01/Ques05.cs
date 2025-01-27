using System;

class Program{
    // Function to print multiplication table from 6 to 9
    public static void MultiplicationTable(int num){
        int []table = new int[10];
        for(int i=0;i<10;i++){
            table[i] = num*(i+1);
        }
        for(int i=0;i<10;i++){
            Console.WriteLine("{0} * {1} = {2}",num,i+1,table[i]);
        }
    }
    public static void Main(string[]args){
        Console.Write("Enter a number to print the table : ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num >= 6 && num <= 9){
            MultiplicationTable(num);
        }else{
            Console.WriteLine("Please enter a number from 6 to 9");
        }
    }
}