using System;
using System.Text;
class ConcatenateString{
    public static string StConc(string []arr){
        StringBuilder sb = new StringBuilder();
        for(int i=0;i<arr.Length;i++){
            sb.Append(arr[i]);
        }
        return sb.ToString();
    }
    public static void Main(string []args){
        string []str = {"Hello"," this"," Yogesh!"};
        Console.WriteLine(StConc(str));
    }
}