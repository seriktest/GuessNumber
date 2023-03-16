namespace GuessNumberApp;

/// <summary>
/// Интерфейс для вывода сообщений, один метот Print, для реализации в разных классах
/// принцип разделения интерфейса
/// </summary>
public interface IView
{
    void Print(string msg);
}
