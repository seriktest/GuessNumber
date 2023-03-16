namespace GuessNumberApp;

/// <summary>
/// Реализация интефейса, в данном случае для вывода сообщения используется класс Console
/// </summary>
public class ConcoleView : IView
{
    public void Print(string msg)
    {
        Console.WriteLine(msg);
    }
}