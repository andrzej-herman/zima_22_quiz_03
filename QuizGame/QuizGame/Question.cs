namespace QuizGame
{
    public class Question
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Content { get; set; }
        public List<Answer> Answers { get; set; }

        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine("Pytanie za " + Category + " pkt");
            Console.WriteLine();
            Console.WriteLine(Content);
            Console.WriteLine();
            foreach (var a in Answers)
                Console.WriteLine(a.Id + ". " + a.Content);

            Console.WriteLine();
            Console.Write("Proszę nacisnąć 1, 2, 3 lub 4 => ");
        }
    }
}
