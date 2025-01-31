using System;

class Program
{
    //program to check weather a string is palidrome or not
    public static bool Palidrome(string str){
        int i = 0;
        int j = str.Length-1;
        while(i<j){
            if(str[i] != str[j]){
                return false;
            }
            i++;
            j--;
        }
        return true;
    }

    public static void Main(string []args){
        Console.Write("Enter a string : ");
        string str = Console.ReadLine();
        if(Palidrome(str)){
            Console.Write("Yes, palindrome");
        }else{
            Console.Write("No, not a palindrome");
        }
    }
}
