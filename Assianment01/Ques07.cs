using System;

class FirstNegativeElement{
    public static int LinearSearch(int []arr){
        for(int i=0;i<arr.Length;i++){
            if(arr[i]<0){
                return i;
            }
        }
        return -1;
    }
    public static void Main(string []args){
        int []arr = {12,3,4,4,-12,44};
        Console.WriteLine(LinearSearch(arr));
    }
}