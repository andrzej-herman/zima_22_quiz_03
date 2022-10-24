using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    public class Game
    {
        // konstruktor
        public Game()
        {
            Questions = new List<Question>();
            CreateQuestions();
            CurrentCategory = 100;
        }

        // właściwości
        public List<Question> Questions { get; set; }
        public int CurrentCategory { get; set; }
        public Question CurrentQuestion { get; set; }

        // metody
        // display welcome screen
        public void Welcome()
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
        }

        // create all questions
        private void CreateQuestions()
        {
            // temporary we create 2 questions one for 100 and second for 200
            // later we create more questions in different way
            
            var p1 = new Question
            {
                Id = 1,
                Content = "Jakie miasto jest stolicą Ukrainy?",
                Category = 100,
                Answers = new List<Answer>()    
            };

            p1.Answers.Add(new Answer
            {
                Id = 1,
                Content = "Kijów",
                IsCorrect = true,
            });

            p1.Answers.Add(new Answer
            {
                Id = 2,
                Content = "Odessa",
                IsCorrect = false,
            });

            p1.Answers.Add(new Answer
            {
                Id = 3,
                Content = "Charków",
                IsCorrect = false,
            });

            p1.Answers.Add(new Answer
            {
                Id = 4,
                Content = "Lwów",
                IsCorrect = false,
            });

            var p2 = new Question
            {
                Id = 1,
                Content = "W którym roku wybuchła II wojna światowa?",
                Category = 200,
                Answers = new List<Answer>()
            };

            p2.Answers.Add(new Answer
            {
                Id = 1,
                Content = "1939",
                IsCorrect = true,
            });

            p2.Answers.Add(new Answer
            {
                Id = 2,
                Content = "1941",
                IsCorrect = false,
            });

            p2.Answers.Add(new Answer
            {
                Id = 3,
                Content = "1918",
                IsCorrect = false,
            });

            p2.Answers.Add(new Answer
            {
                Id = 4,
                Content = "1945",
                IsCorrect = false,
            });

            Questions.Add(p1);
            Questions.Add(p2);
        }

        // draw question from current category
        public void GetQuestionFromCurrentCategory()
        {
            Question goodQuestion = null;
            foreach (var question in Questions)
            {
                if (question.Category == CurrentCategory)
                {
                    goodQuestion = question;
                    break;
                }
                   
            }

            CurrentQuestion = goodQuestion;
        }


    }
}


// 100, 200, 500, 1000, 5000