using System;
using System.Text;

class Reverse{
    public static void ReverseUsingStringBuilder(string str){
        StringBuilder sb = new StringBuilder();
        int j = str.Length-1;
        while(j>=0){
            sb.Append(str[j]);
            j--;
        }
        string st = sb.ToString();
        Console.WriteLine(st);
    }
    public static void Main(string []args){
        Console.Write("Enter the string to reverse : ");
        string st = Console.ReadLine();
        ReverseUsingStringBuilder(st);
    }
}