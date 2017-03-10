using System;
class programming{
    public static void Main(){
        double distance = ReadDouble("Enter distance: ");
        Console.Write("Convert to (km or mile): ");
        string func = Console.ReadLine();
        if (func == "km"){
            convertToKilometer(distance);
        }
        else if (func == "mile"){
            convertToMile(distance);
        }
    }

    public static double ReadDouble(string prompt){
        Console.Write(prompt);
        return double.Parse(Console.ReadLine());
    }
    
    public static void convertToKilometer(double mile){
        double km = mile/0.621371 ;
        Console.WriteLine("Result : {0:f2} miles = {1:f2} kms",mile,km);
    }
    
    public static void convertToMile(double km){
        double mile = km*0.621371 ;
        Console.WriteLine("Result : {0:f2} kms = {1:f2} miles",km,mile);
    }
	
}