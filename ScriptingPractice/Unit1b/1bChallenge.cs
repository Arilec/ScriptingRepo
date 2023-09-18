using System;

					
public class Program
{
	public Operators operations;
	public void Main()
	{
		operations = new Operators();
		//Uses the checktemp conditional variable
		Console.WriteLine(operations.checkTemp(Convert.ToInt32(Console.ReadLine())));
		
		
		//Calls "Percent to Grade" function (converting input to int32
		operations.enterPercentage(Convert.ToInt32(Console.ReadLine()));
	}
    //class created to organize void functions
    public class Operators
    {
        //"checking tempurature" void function
        public string checkTemp(float temp)
        {
            //unfortunately, the only way I can think to do this is with an if else chain.
			if (temp < 10) {
				return("Cold! bring a coat and warm clothing");
			} else if (10 <= temp && temp <= 20){
				return("You may want to bring a jacket");
			} else if (20 < temp && temp <= 30) {
				return("Enjoy the nice weather");
			} else {
				return("Hot! Stay hidrated, avoid staying out in the sun for too long");
			}
			
			
			//old unused code
			/*string advice = (temp > 30) ?	"Hot! Stay hidrated, avoid staying out in the sun for too long" : "Enjoy the nice weather";
            Console.WriteLine(advice);*/
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
			
			//here is the switch statement for favored subject
			//The programmed options are English, Math, Science, History, Gym, and Language, with a Default for any other courses
			switch(Console.ReadLine()){
				case "English":
					Console.WriteLine("Keep reading to improve your vocabulary and speed, and practice your handwriting and essay endurance");
					break;
				case "Math":
					Console.WriteLine("practice your operations, study your formulas and make sure you understand every bit of it. If you can, try proving the new equations");
					break;
				case "Science":
					Console.WriteLine("Study the charts related to your field of science, such as the periodic table or solar star chart. Review the relevant math equations and memorize the relevant terms");
					break;
				case "History":
					Console.WriteLine("remember your dates and don't take this subject for granted.");
					break;
				case "Gym":
					Console.WriteLine("Keep active and participate. Be sure you have your gym clothes cleaned and on hand or in a locker");
					break;
				case "Language":
					Console.WriteLine("Study your vocabulary, your conjugations, and your accent");
					break;
				default:
					Console.WriteLine("I'm sorry, I cannot advise you on a course of action, please consult your educator and peers to find an efficient way of improving your favored subject");
					break;
			}
			

        }
    }
}