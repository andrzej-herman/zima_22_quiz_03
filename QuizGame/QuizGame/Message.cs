using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    class Message
    {
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
        }
    }
}
