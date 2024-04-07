using MathGame.Console.Models;

namespace MathGame.Console.GameEngines;
using System;

public static class AdditionEngine
{
    private static readonly Random Random = new();

    private static int _firstNumber;
    private static int _secondNumber;
    
    internal static void EasyAddition()
    {
        var score = 0;
        for (var i = 0; i < 5; i++)
        {
            _firstNumber = Random.Next(1, 9);
            _secondNumber = Random.Next(1, 9);
        
            Console.WriteLine($"{_firstNumber} + {_secondNumber}");
            var userAnswer = Console.ReadLine();
        
            userAnswer = Helpers.ValidateUserAnswer(userAnswer);
        
            var correctAnswer = _firstNumber + _secondNumber;
        
            if (userAnswer != null && int.Parse(userAnswer) == correctAnswer)
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
        
        Helpers.AddToHistory(score, GameType.Addition);
    }

    internal static void MediumAddition()
    {
        var score = 0;
        for (var i = 0; i < 5; i++)
        {
            _firstNumber = Random.Next(10, 99);
            _secondNumber = Random.Next(10, 99);
        
            Console.WriteLine($"{_firstNumber} + {_secondNumber}");
            var userAnswer = Console.ReadLine();
        
            userAnswer = Helpers.ValidateUserAnswer(userAnswer);
        
            var correctAnswer = _firstNumber + _secondNumber;
        
            if (userAnswer != null && int.Parse(userAnswer) == correctAnswer)
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
        
        Helpers.AddToHistory(score, GameType.Addition);
    }

    internal static void HardAddition()
    {
        var score = 0;
        for (var i = 0; i < 5; i++)
        {
            _firstNumber = Random.Next(100, 999);
            _secondNumber = Random.Next(100, 999);
        
            Console.WriteLine($"{_firstNumber} + {_secondNumber}");
            var userAnswer = Console.ReadLine();
        
            userAnswer = Helpers.ValidateUserAnswer(userAnswer);
        
            var correctAnswer = _firstNumber + _secondNumber;
        
            if (userAnswer != null && int.Parse(userAnswer) == correctAnswer)
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
        
        Helpers.AddToHistory(score, GameType.Addition);
    }
}