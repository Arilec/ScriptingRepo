using System;
					
public class Program
{
	public void Main()
	{
		numPyramid(Convert.ToInt32(Console.ReadLine()));
	}
	
	public void numPyramid(int layers) 
	{
		string[] nums = new string[layers];
		for (var i = 0; i < nums.Length; i++)
		{
			nums[i] = Convert.ToString(i+1);

		}
		
		for(var i = 0; i < nums.Length; i++)
		{
			for(var j = 0; j < i; j++)
			{
				nums[i] = nums[i] + Convert.ToString(i+1);
			}
		}
		foreach(var num in nums){
			Console.WriteLine(num);
		}
		
		
	}
}