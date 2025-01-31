using System;
using System.Text;
class Program
{
    //program to remove duplicate character
    public static string RemoveDuplicate(string str){
        StringBuilder sb = new StringBuilder();
        for(int i=0;i<str.Length;i++){
            bool flag = true;
            for(int j=i+1;j<str.Length-1;j++){
                if(str[i] == str[j]){
                    flag = false;
                }
            }
            if(flag){
                sb.Append(str[i]);
            }
        }
        return sb.ToString();
    }

    public static void Main(string []args){
        Console.Write("Enter a string : ");
        string str = Console.ReadLine();
        Console.Write(RemoveDuplicate(str));
    }
}
