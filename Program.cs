using System.ComponentModel.Design;

namespace rock_paper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] shapes = new[] { "rock", "paper", "scissors" };
            string playerChoice;
            string computerChoice;
            int playerScore = 0;
            int computerScore = 0;
            int drawCount = 0;

            Console.WriteLine("Welcome to ROCK PAPER SCISSORS!");

            for (int round = 0; round < 5; round++)
            {
                GetComputerChoice();
                GetPlayerChoice();
                CheckWinner();
                UpdateScore();
            }

            GameResult();

            void GetComputerChoice()
            {
                Random rnd = new();
                computerChoice = shapes[rnd.Next(0, 3)];
            }

            void GetPlayerChoice()
            {
                Console.Write("\nEnter Rock, Paper, or Scissors: ");
                playerChoice = Console.ReadLine().ToLower();
            }

            void CheckWinner()
            {
                if (playerChoice == computerChoice)
                {
                    RoundDraw();
                }
                else if (playerChoice == "rock")
                {
                    if (computerChoice == "scissors") PlayerWinsRound();
                    if (computerChoice == "paper") ComputerWinsRound();
                }
                else if (playerChoice == "paper")
                {
                    if (computerChoice == "rock") PlayerWinsRound();
                    if (computerChoice == "scissors") ComputerWinsRound();
                }
                else if (playerChoice == "scissors")
                {
                    if (computerChoice == "paper") PlayerWinsRound();

                    if (computerChoice == "rock") ComputerWinsRound();
                }
                else
                {
                    Console.WriteLine("UNEXPECTED OUTCOME"); // Temporary check in place
                }
            }

            void PlayerWinsRound()
            {
                Console.WriteLine("RESULT: You win this round");
                playerScore++;
            }

            void ComputerWinsRound()
            {
                Console.WriteLine("RESULT: Computer wins this round");
                computerScore++;
            }

            void RoundDraw()
            {
                Console.WriteLine("RESULT: Draw");
                drawCount++;
            }

            void UpdateScore()
            {
                Console.WriteLine($"SCORE - You: {playerScore} - Computer: {computerScore} - Draws: {drawCount}");
            }

            void GameResult()
            {
                Console.WriteLine("\n");
                if (playerScore == computerScore) Console.WriteLine("It's a tie!");
                if (playerScore > computerScore) Console.WriteLine("You win!");
                if (playerScore < computerScore) Console.WriteLine("You lose!");
            }
        }
    }
}