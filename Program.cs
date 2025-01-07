public class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();
        int yourScore = 0;
        int rivalScore = 0;
        Console.WriteLine("Dice Game");
        Console.WriteLine();
        Console.WriteLine("In this game you and a computer Rivle will play 10 rounds where you will each rool a 6 sided die, and the player with the highest dice value will win the round. the player who wins the most rounds wins the game. Good luck!");
        Console.WriteLine();
        Console.Write("Press any key to start...");
        Console.ReadKey(true);
        Console.WriteLine();
        Console.WriteLine();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Round {i + 1}");
            int rivalRoll = rng.Next(1, 6);
            Console.WriteLine($"Rival rolled a {rivalRoll}");
            Console.Write("Press any key to roll the die...");
            Console.ReadKey(true);
            Console.WriteLine();
            int yourRoll = rng.Next(1, 6);
            Console.WriteLine($"You rolled a {yourRoll}");
            if (yourRoll > rivalRoll)
            {
                Console.WriteLine("You won this round.");
                yourScore++;
                Console.WriteLine($"The score is now - You : {yourScore}. Rival : {rivalScore}.");
            }
            else if (yourRoll < rivalRoll)
            {
                Console.WriteLine("The Rival won this round.");
                rivalScore++;
                Console.WriteLine($"The score is now - You : {yourScore}. Rival : {rivalScore}.");
            }
            else
            {
                Console.WriteLine("This round is a draw!");
                Console.WriteLine($"The score is now - You : {yourScore}. Rival : {rivalScore}.");
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.WriteLine("Game over.");
        Console.WriteLine($"The score is now - You : {yourScore}. Rival : {rivalScore}.");
        if (yourScore > rivalScore)
        {
            Console.WriteLine("You Won!");    
        }
        else if (yourScore < rivalScore)
        {
        Console.WriteLine("You lost!");
        }
        else
        {
            Console.WriteLine("Draw!");
        }
        Console.Write("Press any key to exit...");
        Console.ReadKey(true);
        Console.WriteLine();
        Console.Clear();
        Console.WriteLine("Dice Game was closed");
    }
}
