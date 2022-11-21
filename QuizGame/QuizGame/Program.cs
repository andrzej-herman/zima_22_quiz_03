using QuizGame;

var game = new Game();
var message = new Message();
// Show Welcome Screen
message.ShowWelcomeScreen();
// GetQuestion
while (true)
{
    game.GetQuestion();
    var playerAnswer = game.CurrentQuestion.Display(game.CanUseWheel);
    if (playerAnswer == 5)
    {
        game.CanUseWheel = false;
        game.EliminateTwoAnswers();
        playerAnswer = game.CurrentQuestion.Display(game.CanUseWheel);
    }


    if (game.IsCorrectAnswer(playerAnswer))
    {
        if (game.IsFinalQuestion())
        {
            message.ShowFinalScreen();
            break;
        }
        else
        {
            message.ShowGoodAnswer();
        }
    }
    else
    {
        message.DisplayGameOver();
        break;
    }
}

