using System;
class programming{
	public static void Main(){
		double score1 = ReadDouble("Student score 1 : ");
		double score2 = ReadDouble("Student score 2 : ");
		double score3 = ReadDouble("Student score 3 : ");

		Console.WriteLine("Max : {0:f2}",Max(score1,score2,score3));
		Console.WriteLine("Min : {0:f2}",Min(score1,score2,score3));
		Console.WriteLine("Mean : {0:f2}",Mean(score1,score2,score3));
		Console.WriteLine("Standard Deviation : {0:f2}",Std(score1,score2,score3));

	}

	public static double ReadDouble(string prompt){
		Console.Write(prompt);
		return double.Parse(Console.ReadLine());
	}

	public static double Max(double score1, double score2, double score3){
		double max = Math.Max(score1,score2);
		max = Math.Max(max,score3);
		return max ;
	}

	public static double Min(double score1, double score2, double score3){
		double min = Math.Min(score1,score2);
		min = Math.Min(min,score3);
		return min ;
	}

	public static double Mean(double score1, double score2, double score3){
		return (score1+score2+score3)/3.0;
	}

	public static double Std(double score1, double score2, double score3){
		double mean = Mean(score1,score2,score3);
		return Math.Sqrt((Math.Pow(score1-mean,2)+Math.Pow(score2-mean,2)+Math.Pow(score3-mean,2))/3);
	}

}