using System;

class BubbleSort{
    public static void Sort(int []arr){
        bool flag;
        for(int i=0;i<arr.Length-1;i++){
            flag = false;
            for(int j=0;j<arr.Length-i-1;j++){
                if(arr[j]>arr[j+1]){
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                    flag = true;
                }
            }
            if(!flag){
                break;
            }
        }
    }
    public static void Main(string []args){
        Console.Write("Enter the number of strudent : ");
        int num = Convert.ToInt32(Console.ReadLine());
        int []student = new int[num];
        Console.WriteLine("Enter the marks of students!");
        for(int i=0;i<num;i++){
            student[i] = Convert.ToInt32(Console.ReadLine());
        }
        Sort(student);
        for(int i=0;i<num;i++){
            Console.Write(student[i]+" ");
        }
    }
}