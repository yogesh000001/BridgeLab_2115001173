using System;

class Program{
    //program to calculate the numeber of consonents and vowels
    public static void func(string str){
        int v = 0;
        int c = 0;
        for(int i=0;i<str.Length;i++){
            if(str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u'){
                v++;
            }else{
                c++;
            }
        }
        Console.WriteLine("Number vowels : "+v);
        Console.WriteLine("Number consonent : "+c);
    }
    public static void Main(string []args){
        Console.Write("Enter a string : ");
        string str = Console.ReadLine();
        func(str);
    }
}