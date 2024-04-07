using MathGame.Console.Models;

namespace MathGame.Console;
using System;

internal class Helpers
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
        Console.WriteLine("*******************************************");
        foreach (var game in Games)
        {
            Console.WriteLine($"{game.Date} - {game.GameType}: {game.Score}pts");
        }
        Console.WriteLine("*******************************************");
        Console.WriteLine("Press any key to return to the Main Menu");
        Console.ReadLine();
    }

    internal static void AddToHistory(int gameScore, GameType gameType)
    {
        Games.Add(new Game
        {
            Date = DateTime.Now,
            Score = gameScore,
            GameType = gameType
        });
    }

    internal static int[] GetDivisionNumbers()
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
    
    internal static string?  ValidateUserAnswer( string userAnswer)
    {
        while (string.IsNullOrEmpty(userAnswer) || !Int32.TryParse(userAnswer, out _))
        {
            Console.WriteLine("Your answer needs to be an integer. Try again.");
            userAnswer = Console.ReadLine();
        }

        return userAnswer;
    }
}