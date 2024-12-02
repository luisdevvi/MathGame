﻿namespace MathGame
{
    internal class Game
    {
        Random random = new Random();

        int numberOne = 0;
        int numberTwo = 0;
        int result = 0;
        int userAnswer = 0;

        public void Sum(Menu menu)
        {
            Console.Clear();
            int userScore = 0;
            Console.WriteLine("Sum game: for each correct answer, score +1 point.\n");
            Thread.Sleep(1000);
            for (int i = 0; i < 5; i++)
            {
                numberOne = random.Next(1, 11);
                numberTwo = random.Next(1, 11);
                result = numberOne + numberTwo;

                Console.WriteLine($"What's the result for the Sum of {numberOne} + {numberTwo}");
                userAnswer = int.Parse(Console.ReadLine());

                if (userAnswer == result)
                {
                    Console.WriteLine("Yay, you got it right! You score +1 point!");
                    userScore += 1;
                    Console.WriteLine($"Current score: {userScore}\n");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Oh no, you got it wrong!");
                    Console.WriteLine($"Current score: {userScore}\n");
                    Thread.Sleep(1000);
                }
            }

            Console.WriteLine($"Game result: {userScore} points");

            Console.WriteLine("You want to play another game? (y/n)");
            string anotherGameOption = Console.ReadLine().ToLower();

            switch (anotherGameOption)
            {
                case "y": Sum(menu); break;
                case "n": menu.ShowMenu(); break;
                default: Console.WriteLine("Invalid option... "); break;
            }
        }

        public void Subtraction(Menu menu)
        {
            Console.Clear();
            int userScore = 0;
            Console.WriteLine("Subtraction game: for each correct answer, score +1 point.\n");
            Thread.Sleep(1000);
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    numberOne = random.Next(1, 11);
                    numberTwo = random.Next(1, 11);
                } while (numberOne < numberTwo);

                result = numberOne - numberTwo;

                Console.WriteLine($"What's the result for the Subtraction of {numberOne} - {numberTwo}");
                userAnswer = int.Parse(Console.ReadLine());

                if (userAnswer == result)
                {
                    Console.WriteLine("Yay, you got it right! You score +1 point!");
                    userScore += 1;
                    Console.WriteLine($"Current score: {userScore}\n");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Oh no, you got it wrong!");
                    Console.WriteLine($"Current score: {userScore}\n");
                    Thread.Sleep(1000);
                }
            }

            Console.WriteLine($"Game result: {userScore} points");

            Console.WriteLine("You want to play another game? (y/n)");
            string anotherGameOption = Console.ReadLine().ToLower();

            switch (anotherGameOption)
            {
                case "y": Subtraction(menu); break;
                case "n": menu.ShowMenu(); break;
                default: Console.WriteLine("Invalid option... "); break;
            }
        }

        public void Multiplication(Menu menu)
        {
            Console.Clear();
            int userScore = 0;
            Console.WriteLine("Multiplication game: for each correct answer, score +1 point.\n");
            Thread.Sleep(1000);
            for (int i = 0; i < 5; i++)
            {
                numberOne = random.Next(1, 6);
                numberTwo = random.Next(1, 6);
                result = numberOne * numberTwo;

                Console.WriteLine($"What's the result for the Multiplication of {numberOne} * {numberTwo}");
                userAnswer = int.Parse(Console.ReadLine());

                if (userAnswer == result)
                {
                    Console.WriteLine("Yay, you got it right! You score +1 point!");
                    userScore += 1;
                    Console.WriteLine($"Current score: {userScore}\n");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Oh no, you got it wrong!");
                    Console.WriteLine($"Current score: {userScore}\n");
                    Thread.Sleep(1000);
                }
            }

            Console.WriteLine($"Game result: {userScore} points");

            Console.WriteLine("You want to play another game? (y/n)");
            string anotherGameOption = Console.ReadLine().ToLower();

            switch (anotherGameOption)
            {
                case "y": Multiplication(menu); break;
                case "n": menu.ShowMenu(); break;
                default: Console.WriteLine("Invalid option... "); break;
            }
        }

        public void Division(Menu menu)
        {
            Console.Clear();
            int userScore = 0;
            Console.WriteLine("Division game: for each correct answer, score +1 point.\n");
            Thread.Sleep(1000);
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    numberOne = random.Next(1, 11);
                    numberTwo = random.Next(1, 11);
                } while (numberOne % numberTwo != 0);

                result = numberOne / numberTwo;

                Console.WriteLine($"What's the result for the Division of {numberOne} / {numberTwo}");
                userAnswer = int.Parse(Console.ReadLine());

                if (userAnswer == result)
                {
                    Console.WriteLine("Yay, you got it right! You score +1 point!");
                    userScore += 1;
                    Console.WriteLine($"Current score: {userScore}\n");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Oh no, you got it wrong!");
                    Console.WriteLine($"Current score: {userScore}\n");
                    Thread.Sleep(1000);
                }
            }

            Console.WriteLine($"Game result: {userScore} points");

            Console.WriteLine("You want to play another game? (y/n)");
            string anotherGameOption = Console.ReadLine().ToLower();

            switch (anotherGameOption)
            {
                case "y": Division(menu); break;
                case "n": menu.ShowMenu(); break;
                default: Console.WriteLine("Invalid option... "); break;
            }
        }
    }
}
