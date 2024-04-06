var date = DateTime.UtcNow;

var games = new List<string>();

var name = GetName();

Menu(name);

void Menu(string userName)
{
    Console.WriteLine("***********************************************************************");
    Console.WriteLine($"Hey {userName}, it's {date.DayOfWeek} today\n");

    var isGameOn = true;

    do
    {
        Console.Clear();
        Console.WriteLine("What game would you want to play today? Choose from the options below:");
        Console.WriteLine("V - View Previous Games");
        Console.WriteLine("A - Addition");
        Console.WriteLine("S - Subtraction");
        Console.WriteLine("M - Multiplication");
        Console.WriteLine("D - Division");
        Console.WriteLine("Q - Quit playing");
        Console.WriteLine("***********************************************************************");

        var gameSelected = Console.ReadLine();

        switch (gameSelected.Trim().ToLower())
        {
            case "v":
                GetGames();
                break;
            case "a":
                AdditionGame("Addition game");
                break;
            case "s":
                SubtractionGame("Subtraction game");
                break;
            case "m":
                MultiplicationGame("Multiplication game");
                break;
            case "d":
                DivisionGame("Division game");
                break;
            case "q":
                Console.WriteLine("Goodbye");
                isGameOn = false;
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    } while (isGameOn);
}

void AdditionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var userAnswer = Console.ReadLine();

        var correctAnswer = firstNumber + secondNumber;

        if (int.Parse(userAnswer) == correctAnswer)
        {
            Console.WriteLine("Your answer was correct");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect");
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu");
            Console.ReadLine();
        }
    }

    AddToHistory(score, "Addition");

}

void SubtractionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var userAnswer = Console.ReadLine();

        var correctAnswer = firstNumber - secondNumber;

        if (int.Parse(userAnswer) == correctAnswer)
        {
            Console.WriteLine("Your answer was correct");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect");
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score}");
            Console.ReadLine();
        }
    }

    AddToHistory(score, "Subtraction");
}

void MultiplicationGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var userAnswer = Console.ReadLine();

        var correctAnswer = firstNumber * secondNumber;

        if (int.Parse(userAnswer) == correctAnswer)
        {
            Console.WriteLine("Your answer was correct");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect");
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score} Press any key to go back to the main menu");
            Console.ReadLine();
        }
    }
    
    AddToHistory(score, "Multiplication");
}

int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(0, 99);
    var secondNumber = random.Next(0, 99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}

void DivisionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);

    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var userAnswer = Console.ReadLine();

        var correctAnswer = firstNumber / secondNumber;

        if (int.Parse(userAnswer) == correctAnswer)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question.");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score} Press any key to go back to the main menu");
            Console.ReadLine();
        }
    }

    AddToHistory(score, "Addition");
}

string GetName()
{
    Console.WriteLine("Please enter your name: ");
    var username = Console.ReadLine();
    return username;
}

void GetGames()
{
    Console.Clear();
    Console.WriteLine("Games History");
    Console.WriteLine("*******************************************");
    foreach (var game in games)
    {
        Console.WriteLine(game);
    }

    Console.WriteLine("*******************************************");
    Console.WriteLine("Press any key to return to the Main Menu");
    Console.ReadLine();
}

void AddToHistory(int gameScore, string gameType)
{
    games.Add($"{DateTime.Now} - {gameType}: {gameScore} pts");
}