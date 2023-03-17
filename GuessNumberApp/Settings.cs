namespace GuessNumberApp;

public class Settings : ISettings
{
    public int MaxTries { get; set; }
    public int MaxNumber { get; set; }

    public Settings(int maxTries, int maxNumber)
    {
        MaxTries = maxTries;
        MaxNumber = maxNumber;
    }
    
}