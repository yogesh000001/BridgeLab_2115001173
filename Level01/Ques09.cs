using System;

class Program
{
    public static char MostFrequent(string str){
        char ch = '';
        for(int i=0;i<str.Length;i++){
            int c = 0;
            for(int j=i+1;j<str.Length-1;j++){
                if(str[i] == str[j]){
                    c++;
                }
            }
            if()
        }
    }
    public static void Main(string []args){
        Console.Write("Enter a string : ");
        string str = Console.ReadLine();
    }
}
