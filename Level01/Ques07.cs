using System;

class Program
{
    public static string ToggleWords(string str){
        char []arr = new char[str.Length];
        for(int i=0;i<str.Length;i++){
            char ch = str[i];
            if(ch >= 'A' && ch <= 'Z'){
                arr[i] = (char)(ch + 32);
            }else if(ch >= 'a' && ch <= 'z'){
                arr[i] = (char)(ch - 32);
            }else{
                arr[i] = ch;
            }
        }
        return new string(arr);
    }
    public static void Main(string[]args){
        Console.Write("Enter a string : ");
        string str = Console.ReadLine();
        Console.WriteLine(ToggleWords(str));
    }
}
