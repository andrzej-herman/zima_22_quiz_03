using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    class Message
    {
        internal void DisplayGameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Niestety to zła odpowiedź.");
            Console.WriteLine("GAME OVER");
        }

        internal void ShowFinalScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Brawo, udało CI się ukończyć cały Quiz !!!");
            Console.WriteLine("GAME OVER");
        }

        internal void ShowGoodAnswer()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Brawo, to poprawna odpowiedź.");
            Console.WriteLine("Naciśnij ENTER aby zobaczyć następne pyranie ...");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal void ShowWelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine("** WELCOME TO OUR QUIZ **");
            Console.WriteLine("************************");
            Console.WriteLine("Try to answer 5 questions");
            Console.WriteLine("************************");
            Console.WriteLine("**     GOOD LUCK !!!  **");
            Console.WriteLine("************************");
            Console.WriteLine();
            Console.WriteLine("Nacisnij ENTER aby rozpoczac grę ...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
