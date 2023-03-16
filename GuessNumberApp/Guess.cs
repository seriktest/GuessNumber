namespace GuessNumberApp;

/// <summary>
/// Думаю что и принцип подстановки Барбары Лисков не
/// </summary>
public class Guess : IView
{
    private readonly int _maxNum;
    private readonly int _maxTries;
    private readonly IView _printer;

    /// <summary>
    /// Ну вроде принцип инверсии зависимости соблюден с использованием абстракции в виде класса для вывода на консоль
    /// можно заменить на любой другой без переписывания кода
    /// </summary>
    /// <param name="maxTries">Колическтво попыток</param>
    /// <param name="printer">Вывод текстовых данных</param>
    /// <param name="maxNum"> Максимальное загадываемое число, по умолчанию 100</param>
    public Guess(int maxTries, IView printer, int maxNum = 100)
    {
        _maxNum = maxNum;
        _maxTries = maxTries;
        _printer = printer;
    }

    /// <summary>
    /// Вся логика скрыта в приватном методе, принцип единственной ответственности, наверно)
    /// </summary>
    private void HumanGuess()
    {
        var num = new Random().Next(_maxNum + 1);
        var tries = 0;
        var lastGuess = -1;
        
        while (lastGuess != num && tries < _maxTries)
        {
            if (!int.TryParse(Console.ReadLine(), out lastGuess))
            {
                _printer.Print("Не дури)))");
                continue;
            }

            if (lastGuess == num)
            {
                _printer.Print("Поздравляю! Ты угадал число =)");
                break;
            }

            _printer.Print(lastGuess < num ? "Мое число больше..." : "Мое число меньше...");

            tries++;

            if (tries != _maxTries) continue;
            
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