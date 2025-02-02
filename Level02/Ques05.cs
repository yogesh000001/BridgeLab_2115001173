using System;

class Palindrome{
    //program to check weather a string is palindrome or not
    public static bool Palindrome1(string str){
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
        if(Palindrome1(str)){
            Console.WriteLine(str+" is palidrome");
        }else{
            Console.WriteLine(str+" is not a palidrome");
        }
    }
}