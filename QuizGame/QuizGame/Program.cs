using QuizGame;

var p1 = new Question();
p1.Id = 1;
p1.Content = "Jakie miasto?";
p1.Category = 100;

p1.Ans1 = new Answer();
p1.Ans1.Id = 1;
p1.Ans1.Content = "Kijów";
p1.Ans1.IsCorrect = true;

p1.Ans2 = new Answer();
p1.Ans2.Id = 2;
p1.Ans2.Content = "Lwów";
p1.Ans2.IsCorrect = false;


p1.Ans3 = new Answer();
p1.Ans3.Id = 3;
p1.Ans3.Content = "Odessa";
p1.Ans3.IsCorrect = false;

p1.Ans4 = new Answer();
p1.Ans4.Id = 4;
p1.Ans4.Content = "Charków";
p1.Ans4.IsCorrect = false;




Console.WriteLine();

