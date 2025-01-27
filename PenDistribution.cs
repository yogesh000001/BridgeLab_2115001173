using System;

class PenDistribution{
    public static void DistributePens(){
        int NoOfStudents = 3;
        int NoOfPens = 14;
        int NoOfPensPerStudent = NoOfPens / NoOfStudents;
        int remainingPens = NoOfPens % NoOfStudents;
        Console.WriteLine("The Pen Per Student is "+NoOfPensPerStudent+" and the remaining pens are "+remainingPens);
    }
    public static void Main(string[] args){
        DistributePens();
    }
}