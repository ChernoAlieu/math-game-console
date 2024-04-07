namespace MathGame.Console;
using System;

internal class Menu
{
    private readonly GameEngine _gameEngine = new(); 
    internal void ShowMenu(string userName, DateTime date)
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
                    Helpers.PrintGames();
                    break;
                case "a":
                    _gameEngine.AdditionGame("Addition game");
                    break;
                case "s":
                    _gameEngine.SubtractionGame("Subtraction game");
                    break;
                case "m":
                    _gameEngine.MultiplicationGame("Multiplication game");
                    break;
                case "d":
                    _gameEngine.DivisionGame("Division game");
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
}