namespace MathGame
{
    internal class Menu
    {
        Game game = new Game();
        int userOption = 0;

        public void ShowMenu()
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Math Game!");
            Console.WriteLine("Select a operation to play a game:\n");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - View Game History");
            Console.WriteLine("0 - Exit Game\n");
            userOption = int.Parse(Console.ReadLine());

            switch (userOption)
            {
                case 1: game.Sum(this); break;
                case 2: game.Subtraction(this); break;
                case 3: game.Multiplication(this); break;
                case 4: game.Division(this); break;
                default:
                    {
                        Console.WriteLine("Invalid option...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        ShowMenu();
                        break;
                    }
            }
        }
    }
}
