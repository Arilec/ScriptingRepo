using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
	public Folio[] folios = new Folio[10];
	public Folio folio;
	public int input;
	public void Main()
	{
		while (input != 4)
		{
			//Main Menu
			Console.WriteLine("Welcome to Arbitrary Journaling System");
			Console.WriteLine("Select one from the following options:");
			Console.WriteLine("1. create new Folio");
			Console.WriteLine("2. create entry");
			Console.WriteLine("3. Browse Folios");
			Console.WriteLine("4. Quit");
			input = Convert.ToInt32(Console.ReadLine());
			//1. Create New Folio
			if (input == 1)
			{
				Console.WriteLine("Select Save Slot");
				for (int i = 0; i <= folios.Length-1; i++)
				{
					string a;
					Folio folref = folios[i];
					if (folref.Title != null)
					{
						a = folref.Title;
					} else {
						a = "";
					}
					Console.WriteLine((i+1) + ": " + a);
				}
			} else if (input == 2)
			{
				
			}
		}
	}
}

public class Entry
{
	public string entryTitle = Console.ReadLine();
	public string entryText = Console.ReadLine();
}

public class Folio
{
	public string Title;
	public Entry[] entries = new Entry[10];
}