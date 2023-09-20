//the goal of this lab is to make a number pyramid For Example:
/* 1
   22
   333
   4444
   55555 */

using System;

public class Program {

    public static void Main() {
        int numPyramid = Convert.ToInt32(Console.ReadLine());

		for (int i = 1; i <= numPyramid; i++) //i is an integer that we run as less than the inputed number so that we get that many lines
		{
			{
			int x = 0;
			while(x < i) //x is an integer that is run before a new line so we can get a number printed a number of times = to the inputed number.
			{
				Console.Write(i);
				if (x < i)
				{
					x++;	
				}
			
			}
		Console.WriteLine(); //putting this in the correct place to print a new line after the number is printed the correct number of times.
			}
		}
    }
}