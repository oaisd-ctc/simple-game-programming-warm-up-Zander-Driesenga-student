public class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();
        Console.WriteLine("Dice Game");
        Console.WriteLine("In this game you and a computer Rivle will play 10 rounds where you will each rool a 6 sided die, and the player with the highest dice value will win the round. the player who wins the most rounds wins the game. Good luck!");
        Console.Write("Press any key to start...");
        Console.ReadLine();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Round {i + 1}");


        }
    }
}
