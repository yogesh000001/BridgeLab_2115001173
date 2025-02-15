using System;
using System.Text;
class RemoveDuplicate{
    public static void Remove(string str){
        StringBuilder sb = new StringBuilder();
        for(int i=0;i<str.Length;i++){
            bool found = false;
            for(int j=0;j<i;j++){
                if(str[j] == str[i]){
                    found = true;
                    break;
                }
            }
            if(!found){
                sb.Append(str[i]);
            }
        }
        string st = sb.ToString();
        Console.WriteLine(st);
    }
    public static void Main(string []args){
        string str = "abcabc";
        Remove(str);
    }
}