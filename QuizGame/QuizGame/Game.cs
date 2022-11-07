using Newtonsoft.Json;
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
            CurrentCategory = 100;
            CreateQuestions();
            Random = new Random();
        }

        // właściwości
        public List<Question> AllQuestions { get; set; }
        public int CurrentCategory { get; set; }
        public Question CurrentQuestion { get; set; }
        public Random Random { get; set; }


        // create all questions
        private void CreateQuestions()
        {
            var path = $"{Directory.GetCurrentDirectory()}\\questions.json";
            var json = File.ReadAllText(path);
            AllQuestions = JsonConvert.DeserializeObject<List<Question>>(json);
        }

        // draw question from current category
        public void GetQuestion()
        {
            var questionsCat = AllQuestions.Where(q => q.Category == CurrentCategory).ToList();
            var number = Random.Next(0, questionsCat.Count);
            var selectedQuestion = questionsCat[number];
            selectedQuestion.Answers = selectedQuestion.Answers.OrderBy(a => Random.Next()).ToList();
            var index = 1;
            foreach (var a in selectedQuestion.Answers)
            {
                a.DisplayOrder = index;
                index++;
            }
            
            
            CurrentQuestion = selectedQuestion;
        }


    }
}


// 100, 200, 500, 1000, 5000