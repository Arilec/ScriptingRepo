// See https://aka.ms/new-console-template for more information
using System;
					
public class Program
{
	//calls operator class and names it operations
	Operator Operations;
	public void Main()
	{
		//assigns operator class
		Operations = new Operator();
		
		//call numPyramid
		Operations.numPyramid(Convert.ToInt32(Console.ReadLine()));
		//
		
		//call numGuesser
		Operations.NumberGuesser();
		//
	}
	
	
	public class Operator {
		public void numPyramid(int layers) 
		{
			//I'm not sure about the necessity of the array, bit here it is
			int[] nums = new int[layers];
			
			//The builder of the number pyramid
			for(var i = 1; i <= nums.Length; i++)
			{
				for(var j = 1; j <= i; j++)
				{
					Console.Write(i);
				}
				Console.WriteLine();
			}
		}
		//Number Guesser function
		public void NumberGuesser() {
			//assigns the random class
			var rand = new Random();
			
			//Variable housekeeping
			int correctNum = rand.Next(1,11);
			int guess;
			int NumOfGuesses = 0;
			
			//GameText
			Console.WriteLine("I'm thinking of a number between one and 10, try and guess it");
			
			//The Do/While loop that enables replayablility
			do {
				guess = Convert.ToInt32(Console.ReadLine());
				NumOfGuesses++;
				
				if (guess > correctNum) {
					Console.WriteLine("Darn, You're over, try again?");
				} else if (guess < correctNum) {
					Console.WriteLine("Oop, You're under, try again?");
				}
			} while (guess != correctNum);
			//congradulations
			Console.WriteLine("Congradulations, you got it");
			Console.WriteLine("You guessed " + NumOfGuesses + " times");
			
		}
	}
}