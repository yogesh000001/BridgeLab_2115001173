using System;

class SelectionSort{
    public static void SortExamScore(int []arr){
        for(int i=0;i<arr.Length-1;i++){
            int currMax = i;
            for(int j=i+1;j<arr.Length;j++){
                if(arr[currMax]>arr[j]){
                    currMax = j;
                }
            }
            int temp = arr[currMax];
            arr[currMax] = arr[i];
            arr[i] = temp;
        }
    }
    public static void Main(string []args){
        Console.Write("Enter the number of strudent : ");
        int num = Convert.ToInt32(Console.ReadLine());
        int []student = new int[num];
        Console.WriteLine("Enter the score of Exam!");
        for(int i=0;i<num;i++){
            student[i] = Convert.ToInt32(Console.ReadLine());
        }
        SortExamScore(student);
        for(int i=0;i<num;i++){
            Console.Write(student[i]+" ");
        }
    }
}