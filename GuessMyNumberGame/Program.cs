using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            // Implement Bisection algorithm

            int[] n = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("\n\tPlease write your number between 1-10: ");
            int guess = int.Parse(Console.ReadLine());
            if (n.Length > guess)
            {
                for (int i = 1; i <= guess; i++)
                {
                    Console.Write("{0}", i);
                }
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("\n\tInvalid input. Please enter a number between 1-10.");
                guess = int.Parse(Console.ReadLine());

                return;
            }

            // human plays

            GuessMyNumber game = new GuessMyNumber();
            game.HumanPlay(game.GetArr(), true);


            //computer plays

            int number = game.GetNumber(1, 1000);
            game.ComputerPlay(game.GetArr(), number);



        }  
  

    }


}
