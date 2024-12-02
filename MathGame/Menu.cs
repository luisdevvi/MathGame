namespace MathGame
{
    internal class Menu
    {
        Game game = new Game();
        public List<string> gameHistory = new List<string>();
        int userOption = 0;
        public int difficulty = 0;

        public void ShowMenu()
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Math Game!");
            Console.WriteLine("Select a operation to play a game:\n");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Random Game");
            Console.WriteLine("6 - View Game History");
            Console.WriteLine("0 - Exit Game\n");
            userOption = int.Parse(Console.ReadLine());

            switch (userOption)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("\nSelect the difficulty of game:\n");
                    Console.WriteLine("1 - Easy");
                    Console.WriteLine("2 - Normal");
                    Console.WriteLine("3 - Hard");
                    difficulty = int.Parse(Console.ReadLine());

                    if (userOption == 5)
                    {
                        int randomNumber = new Random().Next(1, 5);
                        switch (randomNumber)
                        {
                            case 1: game.Sum(this); break;
                            case 2: game.Subtraction(this); break;
                            case 3: game.Multiplication(this); break;
                            case 4: game.Division(this); break;
                        }
                    }
                    else if (userOption == 1) game.Sum(this);
                    else if (userOption == 2) game.Subtraction(this);
                    else if (userOption == 3) game.Multiplication(this);
                    else if (userOption == 4) game.Division(this);
                    break;


                case 6:
                    if (gameHistory.Count == 0)
                    {
                        Console.WriteLine("No game history...");
                        Thread.Sleep(1000);
                        ShowMenu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Game history:\n");
                        foreach (string history in gameHistory)
                        {
                            Console.WriteLine(history);
                        }
                        Console.WriteLine("\nPress any key to return to menu");
                        Console.ReadKey();
                        ShowMenu();
                    }
                    break;

                case 0:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option...");
                    Thread.Sleep(1000);
                    Console.Clear();
                    ShowMenu();
                    break;
            }
        }
    }
}
