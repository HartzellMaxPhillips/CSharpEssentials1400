/* Create a program that prompts the user to enter their three favorite foods. Use an array to store these food items. Display each item on a new line with a message, such as "I love [food item]!". 
Use a loop to iterate through the array and print the messages.*/

using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("What are your three favorite foods?");
		string Fooditem1 = (Console.ReadLine());// these lines are getting the food from the user
		string Fooditem2 = (Console.ReadLine());
		string Fooditem3 = (Console.ReadLine());
		string[] food = {Fooditem1, Fooditem2, Fooditem3}; //Here's the requested array with the food items.

		for (int i = 0; i < 3; i++) //Here's the loop and the reference to the array to output
		{
			Console.WriteLine("I Love " + food[i]); 
		} 
	}
}