using System;
					
public class Program
{
	Operator operations;
	public void Main()
	{
		operations = new Operator();
		operations.readCar(Console.ReadLine());
	}
	public class Operator {
		public void readCar(string addition) {
			string[] cars = {"Volvo", "Honda", "Bughati"};
			
			foreach (var car in cars){
				Console.WriteLine("I own a "+ car);
			}
			Console.WriteLine("I own a "+ addition);
		}
	}
}