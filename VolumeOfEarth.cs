using System;

class Abc{
    //Calculating the volume of earth in cubic kilometers and cubic miles
    public static void volume(){
        double radiusOfEarthKm = 6378;
        double volumeOfEarthkm = (4.0/3.0) * Math.PI * Math.Pow(radiusOfEarthKm, 3);
        double volumeOfEarthCm = Math.Pow(volumeOfEarthkm, 3) / 4.16818183;
        Console.WriteLine("The volume of earth in cubic kilometers is "+volumeOfEarthkm +" and cubic miles is "+volumeOfEarthCm);
    }
    public static void Main(string []args){
        volume();   
    }
}