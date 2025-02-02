using System;

class HcfLcm{
    //calculating the hcf of two numbers
    public static int Hcf(int num1,int num2){
        int min = num1;
        if(min>num2){
            min = num2;
        }
        int hcf = 0;
        for(int i=min;i>=1;i--){
            if(num1 % i == 0 && num2 % i == 0){
                hcf = i;
                break;
            }
        }
        return hcf;
    }
    //calculating the lcm of two numbers
    public static int Lcm(int num1,int num2,int hcf){
        return (num1*num2)/hcf;
    }
    public static void Main(string []args){
        Console.Write("Enter first number  : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number  : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int hcf = Hcf(num1,num2);
        Console.WriteLine("The hcf of "+num1+" and "+num2+" is : "+hcf);
        Console.WriteLine("The lcm of "+num1+" and "+num2+" is : "+Lcm(num1,num2));
    }
}