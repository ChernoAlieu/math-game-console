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
        var numQuestions = Helpers.ChooseNumberOfQuestions();
        
        for (var i = 0; i < numQuestions; i++)
        {
            _firstNumber = Random.Next(1, 9);
            _secondNumber = Random.Next(1, 9);
        
            Console.Write($"{_firstNumber} + {_secondNumber} = ");
            var userAnswer = Console.ReadLine();
        
            userAnswer = Helpers.ValidateUserAnswer(userAnswer);
        
            var correctAnswer = _firstNumber + _secondNumber;
        
            if (userAnswer != null && int.Parse(userAnswer) == correctAnswer)
            {
                Console.WriteLine("Your answer was correct");
                Console.WriteLine("***********************");
                score++;
            }
            else
            {
                Console.WriteLine("Your answer was incorrect");
                Console.WriteLine("***********************");
            }
        
            Helpers.GameOverMessage(i, score, numQuestions);
        }
        
        Helpers.AddToHistory(score, GameType.Addition, DifficultyLevel.Easy, numQuestions);
    }

    internal static void MediumAddition()
    {
        var score = 0;
        var numQuestions = Helpers.ChooseNumberOfQuestions();
        
        for (var i = 0; i < numQuestions; i++)
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
                Console.WriteLine("***********************");
                score++;
            }
            else
            {
                Console.WriteLine("Your answer was incorrect");
                Console.WriteLine("***********************");
            }
        
            Helpers.GameOverMessage(i, score, numQuestions);
        }
        
        Helpers.AddToHistory(score, GameType.Addition, DifficultyLevel.Medium, numQuestions);
    }

    internal static void HardAddition()
    {
        var score = 0;
        var numQuestions = Helpers.ChooseNumberOfQuestions();
        
        for (var i = 0; i < numQuestions; i++)
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
                Console.WriteLine("***********************");
                score++;
            }
            else
            {
                Console.WriteLine("Your answer was incorrect");
                Console.WriteLine("***********************");
            }
            
            Helpers.GameOverMessage(i, score, numQuestions);
        }
        
        Helpers.AddToHistory(score, GameType.Addition, DifficultyLevel.Hard, numQuestions);
    }
}