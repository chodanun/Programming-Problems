using System;
class programming{
	public static void Main(){
		double weight = ReadDouble("Doraemon’s weight (kg): ");
		double height = ReadDouble("Doraemon’s height (cm): ");
		double bmi = BmiCalculation(weight,height);

		Console.Write("BMI : {0:f3} => Doreamon is ",bmi);
		if (bmi < 18.5){
			Console.WriteLine("Underweight");
		}
		else if (bmi < 25){
			Console.WriteLine("Normal");
		}
		else if (bmi < 30){
			Console.WriteLine("Overweight");
		}
		else{
			Console.WriteLine("Obese");
		}
		

	}

	public static double ReadDouble(string prompt){
		Console.Write(prompt);
		return double.Parse(Console.ReadLine());
	}

	public static double BmiCalculation(double weight, double height){
		return weight/Math.Pow((height/100),2);
	}

}