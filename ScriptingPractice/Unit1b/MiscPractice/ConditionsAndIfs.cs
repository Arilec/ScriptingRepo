using System;
					
public class Program
{
	public Operations operations;
	public void Main()
	{
		operations = new Operations();
		operations.doMath(10, 4);
		operations.doMath(20, 7);
		operations.doMath(30, 15);
		operations.Compare(4, 3);
		operations.Compare(3, 4);
		operations.CheckPassword("ou812");
	}
	
	
	
	public class Operations 
	{
		public void doMath(int value, int value2) 
		{
			var number = value+value2;
			Console.WriteLine(number);
		}
		
		public void Compare(int value, int value2)
		{
			if (value > value2)
			{
				Console.WriteLine("true, the first is greater");
			} else {
				Console.WriteLine("false, the second is greater");
			}
		}
		public void CheckPassword(string password)
		{
			string result = (password == "ou812") ? "correct Password" : "incorrect password";
			Console.WriteLine(result);
			
		}
	}
}