using MathGame.Console.Models;
namespace MathGame.Console.GameEngines;
using System;

public static class SubtractionEngine
{
    private static readonly Random Random = new();

    private static int _firstNumber;
    private static int _secondNumber;
    
    internal static void EasySubtraction()
    {
        var score = 0;
        var numQuestions = Helpers.ChooseNumberOfQuestions();
        
        for (var i = 0; i < numQuestions; i++)
        {
            _firstNumber = Random.Next(1, 9);
            _secondNumber = Random.Next(1, 9);
        
            Console.WriteLine($"{_firstNumber} - {_secondNumber}");
            var userAnswer = Console.ReadLine();
        
            userAnswer = Helpers.ValidateUserAnswer(userAnswer);
        
            var correctAnswer = _firstNumber - _secondNumber;
        
            if (userAnswer != null && int.Parse(userAnswer) == correctAnswer)
            {
                Console.WriteLine("Your answer was correct");
                score++;
            }
            else
            {
                Console.WriteLine("Your answer was incorrect");
            }
        
            Helpers.GameOverMessage(i, score, numQuestions);
        }
        
        Helpers.AddToHistory(score, GameType.Subtraction, DifficultyLevel.Easy, numQuestions);
    }
    
    internal static void MediumSubtraction()
    {
        var score = 0;
        var numQuestions = Helpers.ChooseNumberOfQuestions();
        for (var i = 0; i < numQuestions; i++)
        {
            _firstNumber = Random.Next(10, 99);
            _secondNumber = Random.Next(10, 99);
        
            Console.WriteLine($"{_firstNumber} - {_secondNumber}");
            var userAnswer = Console.ReadLine();
        
            userAnswer = Helpers.ValidateUserAnswer(userAnswer);
        
            var correctAnswer = _firstNumber - _secondNumber;
        
            if (userAnswer != null && int.Parse(userAnswer) == correctAnswer)
            {
                Console.WriteLine("Your answer was correct");
                score++;
            }
            else
            {
                Console.WriteLine("Your answer was incorrect");
            }
        
            Helpers.GameOverMessage(i, score, numQuestions);
        }
        
        Helpers.AddToHistory(score, GameType.Subtraction, DifficultyLevel.Medium, numQuestions);
    }
    
    internal static void HardSubtraction()
    {
        var score = 0;
        var numQuestions = Helpers.ChooseNumberOfQuestions();
        
        for (var i = 0; i < numQuestions; i++)
        {
            _firstNumber = Random.Next(100, 999);
            _secondNumber = Random.Next(100, 999);
        
            Console.WriteLine($"{_firstNumber} - {_secondNumber}");
            var userAnswer = Console.ReadLine();
        
            userAnswer = Helpers.ValidateUserAnswer(userAnswer);
        
            var correctAnswer = _firstNumber - _secondNumber;
        
            if (userAnswer != null && int.Parse(userAnswer) == correctAnswer)
            {
                Console.WriteLine("Your answer was correct");
                score++;
            }
            else
            {
                Console.WriteLine("Your answer was incorrect");
            }
        
            Helpers.GameOverMessage(i, score, numQuestions);
        }
        
        Helpers.AddToHistory(score, GameType.Subtraction, DifficultyLevel.Hard, numQuestions);
    }
}