using System;

class InsertionSort{
    public static void Sort(int []arr){
        for(int i=1;i<arr.Length;i++){
            int key = arr[i];
            int j = i - 1;
            while(j>=0 && arr[j]>key){
                arr[j+1] = arr[j];
                j--;
            }
            arr[j+1] = key;
        }
    }
    public static void Main(string []args){
        Console.Write("Enter the number of employee id  : ");
        int num = Convert.ToInt32(Console.ReadLine());
        int []employeeId = new int[num];
        Console.WriteLine("Enter the employee id!");
        for(int i=0;i<num;i++){
            employeeId[i] = Convert.ToInt32(Console.ReadLine());
        }
        Sort(employeeId);
        for(int i=0;i<num;i++){
            Console.Write(employeeId[i]+" ");
        }
    }
}