using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int mystery = number.Next(1,999);
            Console.WriteLine("Hello , Let's play a game of Guess The Number! I have a number between 1 and 999, you have 4 tries to guess it.");
            for (int i = 4; i > 0; i--) {
                int guess = int.Parse(Console.ReadLine());
                if (guess == mystery) {
                    Console.WriteLine("You guessed it, you win! The number was {0}" , mystery);
                    break;
                    }
                else
                {
                Console.WriteLine("Nope, that was not the number, try again!"); 
                }

            }
            Console.WriteLine("Looks like you did not guess the right number, it was actually {0}" , mystery);
        }
    }
}
