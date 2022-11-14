namespace QuizGame
{
    public class Question
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Content { get; set; }
        public List<Answer> Answers { get; set; }

        public int Display()
        {
            while(true)
            {
                QuestionText();
                if (int.TryParse(Console.ReadLine(), out int x) && x > 0 && x < 5)
                {
                    return x;
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


        private void QuestionText()
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
            Console.Write("Proszę nacisnąć 1, 2, 3 lub 4 => ");
        }
    }
}
