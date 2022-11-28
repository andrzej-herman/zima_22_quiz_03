using Quiz;
using QuizGame;
using System;



decimal price = 34.50m;
Console.WriteLine(CurrencyTools.ConvertToCurrency(price));










// utworzyliśmy obiekt typu Game
var game = new Game();

// utworzyliśmy obiekt typu Message


// Show Welcome Screen
Message.ShowWelcomeScreen();
// GetQuestion
while (true)
{
    game.GetQuestion();
    var playerAnswer = Message.Display(game.CurrentQuestion, game.CanUseWheel);
    if (playerAnswer == 5)
    {
        game.CanUseWheel = false;
        game.EliminateTwoAnswers();
        playerAnswer = Message.Display(game.CurrentQuestion, game.CanUseWheel);
    }


    if (game.IsCorrectAnswer(playerAnswer))
    {
        if (game.IsFinalQuestion())
        {
            Message.ShowFinalScreen();
            break;
        }
        else
        {
            Message.ShowGoodAnswer();
        }
    }
    else
    {
        Message.DisplayGameOver();
        break;
    }
}

