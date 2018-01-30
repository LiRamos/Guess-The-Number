using System;

namespace ConsoleApp6
{
    class GuessTheNumber
    {
        static void Main(string[] args)
        {
            Random number = new Random(); 
            int mystery = number.Next(1,999); //A random number is generated between 1 and 999
            Console.WriteLine("Hello , Let's play a game of Guess The Number! I have a number between 1 and 999, you have 10 tries to guess it.");
            for (int i = 10; i > 0; i--) {//10 tries are given to the user to input a guess.
                int guess = int.Parse(Console.ReadLine());//The string they enter is converted into an int.
                if (guess == mystery) {
                    Console.WriteLine("You guessed it, you win! The number was {0}" , mystery); //If they guess the correct number, the game is over and the mystery number is revealed to confirm it was the right choice.
                    break;
                    }
                else
                {
                Console.WriteLine("Nope, that was not the number, try again!"); 
                }

            }
            Console.WriteLine("Looks like you did not guess the right number, it was actually {0}" , mystery);//If they don't guess it in 10 tries, the number is revealed
        }
    }
}
