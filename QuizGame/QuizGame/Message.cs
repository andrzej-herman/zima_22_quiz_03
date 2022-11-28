using Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    public static class Message
    {
        internal static void DisplayGameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Niestety to zła odpowiedź.");
            Console.WriteLine("GAME OVER");
        }

        internal static void ShowFinalScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Brawo, udało CI się ukończyć cały Quiz !!!");
            Console.WriteLine("GAME OVER");
        }

        internal static void ShowGoodAnswer()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Brawo, to poprawna odpowiedź.");
            Console.WriteLine("Naciśnij ENTER aby zobaczyć następne pyranie ...");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static void ShowWelcomeScreen()
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

        public static int Display(Question question, bool canUseWheel)
        {
            while (true)
            {
                QuestionText(question, canUseWheel);
                var key = Console.ReadLine();
                if (IsCorrectKey(key))
                {
                    if (key.ToLower() == "k") return 5;
                    else
                        return int.Parse(key);
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nacisnąłeś nieprawidłowy klawisz");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private static bool IsCorrectKey(string key)
        {
            if (key.ToLower() == key.ToLower()) return true;
            if (int.TryParse(Console.ReadLine(), out int x) && x > 0 && x < 5)
                return true;

            return false;
        }


        private static void QuestionText(Question question, bool canUseWheel)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Pytanie za " + question.Category + " pkt");
            Console.WriteLine();
            Console.WriteLine(question.Content);
            Console.WriteLine();
            foreach (var a in question.Answers)
                Console.WriteLine(a.DisplayOrder + ". " + a.Content);

            Console.WriteLine();

            var message = canUseWheel
                ? "Proszę nacisnąć 1, 2, 3, 4 lub naciśnij K aby użyć koła ratunkowego => "
                : "Proszę nacisnąć 1, 2, 3 lub 4 => ";

            Console.WriteLine(message);

        }

    }
}
