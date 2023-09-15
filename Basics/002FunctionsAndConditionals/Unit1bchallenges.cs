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