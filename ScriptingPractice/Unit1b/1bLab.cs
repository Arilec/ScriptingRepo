using System;

					
public class Program
{
	public Operators operations;
	public void Main()
	{
		operations = new Operators();
		//Calls "Checking tempurature" function (converting input to int32
		operations.checkTemp(Convert.ToInt32(Console.ReadLine()));
		
		//Calls "Percent to Grade" function (converting input to int32
		operations.enterPercentage(Convert.ToInt32(Console.ReadLine()));
	}
    //class created to organize void functions
    public class Operators
    {
        //"checking tempurature" void function
        public void checkTemp(float temp)
        {
            //Ternary Operator
            string advice = (temp > 30) ? "Hot! Stay hidrated, avoid staying out in the sun for too long" : "Enjoy the nice weather";
            Console.WriteLine(advice);
        }
        //"Percent to Grade" void function
        public void enterPercentage (int grade)
        {
            /*switch statement with && operators to give range.
            this is a C# 7 feature and thus doesn't work with my
            compiler, still cool though

            switch(grade)
            {
                case int i when i <= 100 && i >= 90:
                    Console.WriteLine("A");
                    break;
                case int i when i < 90 && i >= 80:
                    Console.WriteLine("B");
                    break;
                case int i when i < 80 && i >= 70:
                    Console.WriteLine("C");
                    break;
                case int i when i < 70 && i >= 60:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            } 
            
            We will use a if else chain instead
            Apologies for the clutter*/
            int i = grade;

            if (i <= 100 && i >= 90){
                Console.WriteLine("A");
            } else if (i < 90 && i >= 80){
                Console.WriteLine("B");
            } else if (i < 80 && i >= 70){
                Console.WriteLine("C");
             } else if (i < 70 && i >= 60){
                Console.WriteLine("D");
             } else {
                Console.WriteLine("F");
             }


        }
    }
}