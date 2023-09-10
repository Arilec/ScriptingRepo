using System;
					
public class Program
{
	public gameStates gamestates;
	
	public void Main()
	{
		gamestates = new gameStates();
		gamestates.currentstate = gameStates.States.Playing;
		gamestates.checkState();
		
	}
	
	
	
	public class gameStates {
		public enum States {
			Starting, 
			Playing, 
			Ending
		}
		
		public States currentstate = States.Starting;
		
		public void checkState(){
			switch (currentstate) {
				case States.Starting:
					Console.WriteLine("Starting");
					break;
				case States.Playing:
					Console.WriteLine("Playing");
					break;
				case States.Ending:
					Console.WriteLine("Ending");
					break;
			}
		}
	}
}
