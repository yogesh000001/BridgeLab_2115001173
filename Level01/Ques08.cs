using System;

class Program{
    //program to check two string lexicographically 
    public static int LexicographicalOrder(string str1,string str2){
        int m = Math.Min(str1.Length,str2.Length);
        for(int i=0;i<m;i++){
            if(str1[i]>str2[i]){
                return 1;
            }
            if(str1[i]<str2[i]){
                return -1;
            }
        }
        if(str1.Length>str2.Length){
            return 1;
        }
        if(str1.Length<str2.Length){
            return -1;
        }
        return 0;
    }
    public static void Main(string[]args){
        Console.Write("Enter first string : ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string : ");
        string str2 = Console.ReadLine();
        int ans = LexicographicalOrder(str1,str2);
        if(ans == 0){
            Console.WriteLine("Both the strings are equal");
        }else if(ans > 0){
            Console.WriteLine("First string is greater than second string");
        }else{
            Console.WriteLine("Second string is greater than first string");
        }
    }
}