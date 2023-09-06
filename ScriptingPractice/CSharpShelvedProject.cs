public class Program
{
	
	public void Main()
	{
			
	}
}

public class Entry
{
	public string entryTitle = Console.ReadLine();
	public string entryText = Console.ReadLine();
}
public class Folio
{
	public string Title = Console.ReadLine();
	public var Entries = new List<Entry>();
}