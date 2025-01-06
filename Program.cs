using System;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Dice Game\n");
        Console.WriteLine("In this game you and a computer Rival will play 10 rounds\nwhere you will each roll a 6 - sided dice, and the player\nwith the highest dice value will win the round. The player\nwho wins the most rounds wins the game. Good luck!\n");
        Console.Write("Press any key to start...");
        Console.ReadLine();
        int round = 1;
        int playerScore = 0;
        int rivalScore = 0;
        Random rnd = new Random();
        do
        {
            int playerRoll = rnd.Next(1, 6);
            int rivalRoll = rnd.Next(1, 6);

            int winLoss = 0;

            if (playerRoll > rivalRoll)
            {
                playerScore++;
                winLoss = 1;
            }
            else
            {
                rivalScore++;
                winLoss = -1;
            }

            Console.WriteLine($"Round {round}");
            Console.WriteLine($"Rival rolled a {rivalRoll}");
            Console.Write("Press any key to roll the dice...");
            Console.Read();

            Console.WriteLine($"You rolled a {playerRoll}");
            if (winLoss == 1) Console.WriteLine("You won this round.");
            if (winLoss == 0) Console.WriteLine("This round is a draw");
            if (winLoss == -1) Console.WriteLine("The Rival won this round");

            Console.WriteLine($"The score is now - You: {playerScore}. Rival: {rivalScore}.");
            Console.Write("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine();

            round++;
        } while (round <= 10);

        Console.WriteLine("Game Over.");
        Console.WriteLine($"The score is now - You: {playerScore}. Rival: {rivalScore}.");
        if(playerScore > rivalScore) Console.WriteLine("You won the game.");
        if(playerScore < rivalScore) Console.WriteLine("The Rival won the game.");
        if(playerScore == rivalScore) Console.WriteLine("The game is a draw.");

        Console.Write("Press any key to exit...");
        int e = Console.Read();

        Console.Clear();
        Console.WriteLine("The Dice Game was exited.");
    }
}