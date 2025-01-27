using System;

class Program{
    // Function to check the voting eligibility of the students.
    public static void VotingEligibility(int []arr){
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i]>=18){
                Console.WriteLine("The student with the age "+arr[i]+" is eligible for voting.");
            }
            else{
                Console.WriteLine("The student with the age "+arr[i]+" is not eligible for voting.");
            } 
        }
    }
    
    public static void Main(string[]args){
        int []arr = new int[10];
        Console.WriteLine("Enter the age of students!");
        for(int i=0;i<10;i++){
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        VotingEligibility(arr);
    }
}