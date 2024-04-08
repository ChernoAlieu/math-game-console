namespace MathGame.Console.Models;

internal class Game
{
    public int Score { get; set; }
    public DateTime Date { get; set; }
    public GameType GameType { get; set; }
    public DifficultyLevel DifficultyLevel { get; set; }
    public int NumberOfQuestions { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}

internal enum DifficultyLevel
{
    Easy,
    Medium,
    Hard
}