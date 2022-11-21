namespace QuizGame
{
    public class Question
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Content { get; set; }
        public List<Answer> Answers { get; set; }

        public int Display(bool canUseWheel)
        {
            while (true)
            {
                QuestionText(canUseWheel);
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
                    Console.ForegroundColor= ConsoleColor.Red;  
                    Console.WriteLine("Nacisnąłeś nieprawidłowy klawisz");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private bool IsCorrectKey(string key)
        {
            if (key.ToLower() == key.ToLower()) return true;
            if (int.TryParse(Console.ReadLine(), out int x) && x > 0 && x < 5)
                return true;

            return false;
        }


        private void QuestionText(bool canUseWheel)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Pytanie za " + Category + " pkt");
            Console.WriteLine();
            Console.WriteLine(Content);
            Console.WriteLine();
            foreach (var a in Answers)
                Console.WriteLine(a.DisplayOrder + ". " + a.Content);

            Console.WriteLine();

            var message = canUseWheel
                ? "Proszę nacisnąć 1, 2, 3, 4 lub naciśnij K aby użyć koła ratunkowego => "
                : "Proszę nacisnąć 1, 2, 3 lub 4 => ";

            Console.WriteLine(message);

        }
    }
}
