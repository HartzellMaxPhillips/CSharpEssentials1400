/* Create a game where the program generates a random number between 1 and 10. Prompt the user to guess the number. Use a loop to give the user multiple chances to guess. 
Provide feedback after each guess, indicating if the guess is too high or too low. When the user assumes the correct number, display a congratulatory message and the number of attempts made.*/

using System;

public class Program {
	

    public static void Main() 
	{
		Console.WriteLine("Please enter a random seed for the number to generate from");
		int generator = Convert.ToInt32(Console.ReadLine());
		Random rnd = new Random(generator);
		int secretNumber = rnd.Next(1, 11); //Here we get a random number generated for the User to guess.
		Console.WriteLine(secretNumber);
		int guessNumber = 0;
		Console.WriteLine("I'm thinking of a whole number between 1 and 10,");
		gameLoop(guessNumber, secretNumber);
		
    }
	
	public static void gameLoop(int guessNumber, int secretNumber) {
		while (guessNumber != secretNumber) { //The while loop that runs as the game is played

			guessNumber = Convert.ToInt32(Console.ReadLine());
				if (guessNumber < secretNumber) {
					Console.WriteLine("That's too low, guess again!");
				}
				if (guessNumber > secretNumber) 
				{
					Console.WriteLine("That number is too high, try again!");
				}
				if (guessNumber == secretNumber) 
				{
					Console.WriteLine("You guess it right! You win!");
				}
		}
	}
}