using MathGame.Console.Models;

namespace MathGame.Console;

using System;

internal static class Helpers
{
    private static readonly List<Game> Games = new();

    internal static string GetName()
    {
        Console.WriteLine("Please enter your name: ");
        var username = Console.ReadLine();

        while (string.IsNullOrEmpty(username))
        {
            Console.WriteLine("Name can't be empty");
            username = Console.ReadLine();
        }

        return username;
    }

    internal static void PrintGames()
    {
        Console.Clear();
        Console.WriteLine("Games History");
        foreach (var game in Games)
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine($"Date - {game.Date}\n" +
                              $"Game Type - {game.GameType}\n" +
                              $"Difficulty Level - {game.DifficultyLevel}\n" +
                              $"Score - {game.Score}/{game.NumberOfQuestions}pts");
            Console.WriteLine("*******************************************");
        }
        
        Console.WriteLine("Press any key to return to the Main Menu");
        Console.ReadLine();
    }

    internal static void AddToHistory(int gameScore, GameType gameType, DifficultyLevel level, int numQuestions)
    {
        Games.Add(new Game
        {
            Date = DateTime.Now,
            Score = gameScore,
            GameType = gameType,
            DifficultyLevel = level,
            NumberOfQuestions = numQuestions
        });
    }

    internal static int[] GetEasyDivisionNumbers()
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

    internal static int[] GetMediumDivisionNumbers()
    {
        var random = new Random();
        var firstNumber = random.Next(100, 999);
        var secondNumber = random.Next(100, 999);

        var result = new int[2];

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(101, 1000);
            secondNumber = random.Next(101, 1000);
        }

        result[0] = firstNumber;
        result[1] = secondNumber;

        return result;
    }

    internal static int[] GetHardDivisionNumbers()
    {
        var random = new Random();
        var firstNumber = random.Next(1000, 9999);
        var secondNumber = random.Next(1000, 9999);

        var result = new int[2];

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(1001, 9999);
            secondNumber = random.Next(1001, 9999);
        }

        result[0] = firstNumber;
        result[1] = secondNumber;

        return result;
    }

    internal static string? ValidateUserAnswer(string userAnswer)
    {
        while (string.IsNullOrEmpty(userAnswer) || !Int32.TryParse(userAnswer, out _))
        {
            Console.WriteLine("Your answer needs to be an integer. Try again.");
            userAnswer = Console.ReadLine();
        }

        return userAnswer;
    }

    internal static string SelectLevel()
    {
        Console.WriteLine("Difficulty Level");
        Console.WriteLine("*******************************************");
        Console.WriteLine("Select the difficulty level:");
        Console.WriteLine("E - Easy");
        Console.WriteLine("M - Medium");
        Console.WriteLine("H - Hard");
        Console.WriteLine("Q - Back to main menu");

        var levelSelected = Console.ReadLine();

        return levelSelected;
    }

    internal static int ChooseNumberOfQuestions()
    {
        Console.Clear();
        Console.Write("Please enter the number of questions you want to answer: ");
        var numOfQuestions = Console.ReadLine();

        return int.Parse(numOfQuestions ?? throw new InvalidOperationException());
    }

    internal static void GameOverMessage(int i, int score, int numQuestions)
    {
        if (i == numQuestions - 1)
        {
            Console.WriteLine($"Game over.\nYour final score is {score}/{numQuestions}.\nPress any key to go back to the main menu");
            Console.ReadLine();
        }
    }
}