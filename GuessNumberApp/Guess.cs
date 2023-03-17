namespace GuessNumberApp;

/// <summary>
/// Думаю что и принцип подстановки Барбары Лисков не
/// </summary>
public class Guess : IView
{
    
    private readonly IView _printer;
    private readonly ISettings _settings;

    /// <summary>
    /// Ну вроде принцип инверсии зависимости соблюден с использованием абстракции в виде класса для вывода на консоль
    /// можно заменить на любой другой без переписывания кода
    /// </summary>
    /// <param name="printer">Вывод текстовых данных</param>
    /// <param name="settings">Настройки</param>
    public Guess(IView printer, ISettings settings)
    {
        _settings = settings;
        _printer = printer;
    }

    /// <summary>
    /// Вся логика скрыта
    /// </summary>
    private void HumanGuess()
    {
        var lastGuess = -1;
        
        while (lastGuess != _settings.MaxNumber && _settings.MaxTries != 0)
        {
            if (!int.TryParse(Console.ReadLine(), out lastGuess))
            {
                _printer.Print("Не дури)))");
                continue;
            }

            if (lastGuess == _settings.MaxNumber)
            {
                _printer.Print("Поздравляю! Ты угадал число =)");
                break;
            }

            _printer.Print(lastGuess < _settings.MaxNumber ? "Мое число больше..." : "Мое число меньше...");

            _settings.MaxTries--;

            if (_settings.MaxTries != 0) continue;
            
            _printer.Print("Ты проиграл.");
            break;

        }
    }
    
    public void Start()
    {
        _printer.Print("Добро пожаловать в игру угадай число.");
        _printer.Print("Я загадал, а ты угадай.");

        HumanGuess();
    }

    public void Print(string msg)
    {
        _printer.Print(msg);
    }
}