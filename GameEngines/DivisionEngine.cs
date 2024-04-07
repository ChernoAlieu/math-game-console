using MathGame.Console.Models;

namespace MathGame.Console.GameEngines;
using System;

public static class DivisionEngine
{
    internal static void EasyDivision()
    {
        var score = 0;
        for (var i = 0; i < 5; i++)
        {
            var divisionNumbers = Helpers.GetEasyDivisionNumbers();
            var firstNumber = divisionNumbers[0];
            var secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");
            var userAnswer = Console.ReadLine();
            
            userAnswer = Helpers.ValidateUserAnswer(userAnswer);

            var correctAnswer = firstNumber / secondNumber;

            if (userAnswer != null && int.Parse(userAnswer) == correctAnswer)
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
                Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu");
                Console.ReadLine();
            }
        }

        Helpers.AddToHistory(score, GameType.Division);
    }
    
    internal static void MediumDivision()
    {
        var score = 0;
        for (var i = 0; i < 5; i++)
        {
            var divisionNumbers = Helpers.GetMediumDivisionNumbers();
            var firstNumber = divisionNumbers[0];
            var secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");
            var userAnswer = Console.ReadLine();
            
            userAnswer = Helpers.ValidateUserAnswer(userAnswer);

            var correctAnswer = firstNumber / secondNumber;

            if (userAnswer != null && int.Parse(userAnswer) == correctAnswer)
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
                Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu");
                Console.ReadLine();
            }
        }

        Helpers.AddToHistory(score, GameType.Division);
    }
    
    internal static void HardDivision()
    {
        var score = 0;
        for (var i = 0; i < 5; i++)
        {
            var divisionNumbers = Helpers.GetHardDivisionNumbers();
            var firstNumber = divisionNumbers[0];
            var secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");
            var userAnswer = Console.ReadLine();
            
            userAnswer = Helpers.ValidateUserAnswer(userAnswer);

            var correctAnswer = firstNumber / secondNumber;

            if (userAnswer != null && int.Parse(userAnswer) == correctAnswer)
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
                Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu");
                Console.ReadLine();
            }
        }

        Helpers.AddToHistory(score, GameType.Division);
    }
}