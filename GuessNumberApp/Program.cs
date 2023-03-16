
using GuessNumberApp;

var guessGame = new Guess(5, new ConcoleView());
guessGame.Start();

Console.ReadLine();