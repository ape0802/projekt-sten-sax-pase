internal class Program
{
    private static void Main(string[] args)
    {// ROCK PAPER SCISSORS

        string[] options = { "rock", "paper", "scissors" };

        Console.WriteLine("Press [ENTER] to play rock paper scissors!");
        Console.ReadLine();

        bool replay = true;
        while (replay == true)
        {
            Random rnd = new Random();
            var computerans = options[rnd.Next(options.Length)];

            Console.WriteLine("Press R for rock");
            Console.WriteLine("Press P for paper");
            Console.WriteLine("Press S for scissors");

            var ans = Console.ReadKey(true).KeyChar.ToString().ToUpper();
            if (ans == "R")
            {
                ans = options[0];
            }

            else if (ans == "P")
            {
                ans = options[1];
            }

            else if (ans == "S")
            {
                ans = options[2];
            }

            Console.WriteLine();

            if (ans == computerans)
            {
                Console.WriteLine("It's a draw!");
            }
            else if (computerans == "paper" && ans == "rock")
            {
                Console.WriteLine("I chose " + computerans);
                Console.WriteLine("I win!");
            }

            else if (computerans == "scissors" && ans == "paper")
            {
                Console.WriteLine("I chose " + computerans);
                Console.WriteLine("I win!");
            }

            else if (computerans == "rock" && ans == "scissors")
            {
                Console.WriteLine("I chose " + computerans);
                Console.WriteLine("I win!");
            }
            else
            {
                Console.WriteLine("I had " + computerans);
                Console.WriteLine("You win!");
            }

            Console.WriteLine();
            Console.WriteLine("Press [Y] to play again, or any other key to quit");
            Console.WriteLine();
            var replaykey = Console.ReadKey(true).KeyChar.ToString().ToUpper();
            if (replaykey == "Y")
                replay = true;
            else
                Environment.Exit(0);


        }
    }
}