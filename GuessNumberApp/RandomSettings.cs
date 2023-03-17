namespace GuessNumberApp;

public class RandomSettings : ISettings
{
    
    public RandomSettings()
    {
        MaxTries = new Random().Next(5);
        MaxNumber = new Random().Next(100);
    }
    public int MaxTries { get; set; }
    public int MaxNumber { get; }
}