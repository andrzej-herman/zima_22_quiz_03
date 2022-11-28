using Quiz;

namespace QuizDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartGame();
            DisplayQuestion();
        }


        public Game Game { get; set; }

        void StartGame()
        {
            Game = new Game();
            Game.GetQuestion();
        }

        void DisplayQuestion()
        {
            lblCategory.Text = $"Pytanie za {Game.CurrentQuestion.Category} pkt.";
            lblContent.Text = Game.CurrentQuestion.Content;
            lblA1.Text = Game.CurrentQuestion.Answers[0].Content;
            lblA2.Text = Game.CurrentQuestion.Answers[1].Content;
            lblA3.Text = Game.CurrentQuestion.Answers[2].Content;
            lblA4.Text = Game.CurrentQuestion.Answers[3].Content;
        }
    }
}