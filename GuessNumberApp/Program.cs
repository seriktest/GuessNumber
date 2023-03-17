using GuessNumberApp;

var guessGame = new Guess(new ConcoleView(), new Settings(5, 100));

guessGame.Start();

//var guessGameRandom = new Guess(new ConcoleView(), new RandomSettings());
// guessGameRandom.Start();
Console.ReadLine();