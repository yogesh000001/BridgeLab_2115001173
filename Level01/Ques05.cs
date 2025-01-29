using System;

class Program{
    //Program to detect weather entered day and month is in spring season or not
    public static void SpringSeason(int month,int day){
        if((month==3 && day>=20 && day<=31) || (month==4 && day>=1 && day<=30) || (month==5 && day>=1 && day<=31) || (month==6 && day>=1 && day<=20)){
            Console.WriteLine("Entered day and month is in spring season");
        }else{
            Console.WriteLine("Entered day and month is not in spring season");
        }
    }
    public static void Main(string[]args){
        Console.WriteLine("Enter the month : ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the day : ");
        int day = Convert.ToInt32(Console.ReadLine());
        SpringSeason(month,day);
    }
}