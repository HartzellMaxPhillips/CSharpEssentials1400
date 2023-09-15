// Starting with the code in Lab1bchallenge1 and expounding upon it with additional code for the challenge.  
//The line below is the text from the challenge.
//Modify the existing code to check for different temperature ranges and provide more specific advice based on the conditions.

using System;

public class Program  //Here and above along with the coresponding brackets is required to run
{
    public WeatherAdvisory myWeatherAdvisory; //Pulling The function so it's useable by Main

    public void Main() 
    {
        myWeatherAdvisory = new WeatherAdvisory();
     	
		myWeatherAdvisory.tempTaker(45); //Passing a variable into the tempTaker function to give it something to work with.
		myWeatherAdvisory.tempTaker(35);
		myWeatherAdvisory.tempTaker(25);
		myWeatherAdvisory.tempTaker(15);
		myWeatherAdvisory.tempTaker(5);
		myWeatherAdvisory.tempTaker(-5);

    }
}

public class WeatherAdvisory { //A class that could hold multiple functions but is just going to hold one for now.
    public void tempTaker(int temperature)//Here is the beginning of the function with an if statement as requested by the challenge.
	{	
		if (temperature >= 40) { //Else if statements used for greater variety in advice.
			Console.WriteLine ("Heat Advisory, it is extremely hot outside.  stay indoors if possible.");
		}  else if(temperature > 30) {
			Console.WriteLine ("It's hot outside, stay hydrated and avoid staying in the sun too long.");
		} else if(temperature > 20) {
			Console.WriteLine ("Enjoy the nice weather today!");
		} else if(temperature > 10) {
			Console.WriteLine ("It's a little chilly out, advise wearing a jacket or keeping one avaialable.");
		} else if(temperature > 0) {
			Console.WriteLine ("It's very cold outside, a coat is recommended.");	
		} else if(temperature > -10) {
			Console.WriteLine ("It's freezing outside, wear a coat and stay warm!");	
		}
		
	}

}

//Everything below here will be challenge 2
/* Expand the "Exam Grader" program from the lab assignment. 
In addition to displaying the grade based on the exam score, prompt the user to enter their favorite subject. 
Use a switch statement to display a message related to their chosen topic. 
For example, if the issue is "Math," show a message encouraging them to keep practicing and exploring mathematical concepts. 
Customize the messages for different subjects and make it fun and encouraging.*/

using System;

public class Program //Standard stuff
{
    public ExamReader myExamReader;  //Calling from the call ExamReader
	public SubjectMatter mySubjectMatter;	
	
    public void Main ()
    {
        myExamReader = new ExamReader(); //Setting up ExamReader to be used in the running program
		mySubjectMatter = new SubjectMatter();

        myExamReader.gradeTest(95); //Calling the class and then specifying  which function within the class
        myExamReader.gradeTest(85);
		mySubjectMatter.checkSubject();
		
}

public class SubjectMatter 
{
	public enum Subjects 
	{
		Math, Reading, Writing, Science, 
	}  
	public void checkSubject () 
	{
		Console.WriteLine("Which subject among Math, Reading, Writing, and Science, is your favorite? 1 for Math, 2 for Reading, 3 for Writing, and 4 for Science");
		int currentSubject = Convert.ToInt32(Console.ReadLine()); 
	
		switch (currentSubject) 
		{
			case 1:
				Console.WriteLine("Remember to practice your math and do your homework on time to be successful!");
				break;
			case 2:
				Console.WriteLine("Find lots of books that your interested in that are of your grade level and maybe even some that are slightly higher!");
				break;
			case 3:
				Console.WriteLine("Write a variety of things such as poems, books, short stories, and essays.  You got this!");
				break;
			case 4:
				Console.WriteLine("Learn as many facts as you can about observational science and the scientific method!");
				break;
		}
	}
}


public class ExamReader 
{  //Class to hold our function
    public void gradeTest (int grade) 
	{ //Function along with the integer needed
        if (grade >= 90 && grade <= 100) 
		{ //Had to use && for the "and" comparison.  Just a fun thing I learned making this.  
            Console.WriteLine("You're grade is an A");
        } else if (grade >= 80 && grade < 90) 
		{
            Console.WriteLine("You're grade is an B");
        } else if (grade >= 70  && grade < 80)
		{
            Console.WriteLine("You're grade is an C");
        } else if (grade >= 60 && grade < 70)
		{
            Console.WriteLine("You're grade is an D");
        } else if (grade < 60 && grade >= 0)
		{
            Console.WriteLine("You're grade is an F");
        } else if (grade > 100 || grade < 0)
		{
			Console.WriteLine("Invalid Input");
		}
    }
}
}