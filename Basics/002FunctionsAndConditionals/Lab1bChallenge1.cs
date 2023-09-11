//this is for challenge one of the Lab as the file name suggest
//The goal is to create a weather advisory based on temerature
//

using System;

public class Program  //Here and above along with the coresponding brackets is required to run
{
    public TempReader myTempReader; //Pulling The function so it's useable by Main

    public void Main() 
    {
        myTempReader = new TempReader();
     	
		myTempReader.tempTaker(25); //Passing a variable into the tempTaker function to give it something to work with.
		myTempReader.tempTaker(35);
		

    }
}

public class TempReader { //A class that could hold multiple functions but is just going to hold one for now.
    public void tempTaker(int temperature)//Here is the beginning of the function with an if statement as requested by the challenge.
	{
		if(temperature > 30) {
			Console.WriteLine ("It's hot outside, stay hydrated and avoid staying in the sun too long.");
		} else {
			Console.WriteLine ("Enjoy the nice weather today!");
		}
		
	}
}