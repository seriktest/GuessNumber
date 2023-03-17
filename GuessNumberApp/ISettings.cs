namespace GuessNumberApp;

public interface ISettings
{
    int MaxTries { get; set; }
    int MaxNumber { get; }
    
}