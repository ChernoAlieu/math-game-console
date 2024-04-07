using MathGame.Console.GameEngines;

namespace MathGame.Console;
using System;

internal class MainGameEngine
{
    internal static void AdditionGame(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var levelSelected = Helpers.SelectLevel();

        switch (levelSelected)
        {
            case "e":
                AdditionEngine.EasyAddition();
                break;
            case "m":
                AdditionEngine.MediumAddition();
                break;
            case "h":
                AdditionEngine.HardAddition();
                break;
            case "q":
                Console.WriteLine("Main menu");
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }

    internal static void SubtractionGame(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var levelSelected = Helpers.SelectLevel();

        switch (levelSelected)
        {
            case "e":
                SubtractionEngine.EasySubtraction();
                break;
            case "m":
                SubtractionEngine.MediumSubtraction();
                break;
            case "h":
                SubtractionEngine.HardSubtraction();
                break;
            case "q":
                Console.WriteLine("Main menu");
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }

    internal void MultiplicationGame(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var levelSelected = Helpers.SelectLevel();

        switch (levelSelected)
        {
            case "e":
                MultiplicationEngine.EasyMultiplication();
                break;
            case "m":
                MultiplicationEngine.MediumMultiplication();
                break;
            case "h":
                MultiplicationEngine.HardMultiplication();
                break;
            case "q":
                Console.WriteLine("Main menu");
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }

    internal void DivisionGame(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var levelSelected = Helpers.SelectLevel();

        switch (levelSelected)
        {
            case "e":
                DivisionEngine.EasyDivision();
                break;
            case "m":
                DivisionEngine.MediumDivision();
                break;
            case "h":
                DivisionEngine.HardDivision();
                break;
            case "q":
                Console.WriteLine("Main menu");
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }
}