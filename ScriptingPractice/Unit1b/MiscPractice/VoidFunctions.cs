using System;
					
public class Program
{
	public void Main()
	{
		doMath(10, 4);
		doMath(20, 7);
		doMath(30, 15);
	}
	
	public void doMath(int value, int value2) 
	{
		var number = value+value2;
		Console.WriteLine(number);
	}
}