using Newtonsoft.Json;

namespace Quiz
{
    public class Game
    {
        // konstruktor
        public Game()
        {

            CreateQuestions();
            Random = new Random();
            Categories = AllQuestions
                .Select(q => q.Category)
                .Distinct()
                .OrderBy(x => x).ToList();

            //Categories = new List<int> { 100, 200, 300, 400, 500, 750, 1000 };

            CurrentCategory = Categories[CurrentCategoryIndex];
            CanUseWheel = true;
        }

        // właściwości
        public List<Question> AllQuestions { get; set; }
        public int CurrentCategory { get; set; }
        public Question CurrentQuestion { get; set; }
        public Random Random { get; set; }
        public List<int> Categories { get; set; }
        public int CurrentCategoryIndex { get; set; }
        public bool CanUseWheel { get; set; }


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


        public bool IsCorrectAnswer(int playerAnswer)
        {
            return CurrentQuestion.Answers.First(a => a.DisplayOrder == playerAnswer).IsCorrect;
        }

        public bool IsFinalQuestion()
        {
            if (CurrentCategoryIndex == 6) return true;
            else
            {
                CurrentCategoryIndex++;
                CurrentCategory = Categories[CurrentCategoryIndex];
                return false;
            }
        }

        public void EliminateTwoAnswers()
        {
            var badAnswers = CurrentQuestion.Answers.Where(a => !a.IsCorrect);
            var removed = badAnswers.OrderBy(a => Random.Next()).Take(2).ToList();
            CurrentQuestion.Answers.Remove(removed[0]);
            CurrentQuestion.Answers.Remove(removed[1]);
        }
    }
}
