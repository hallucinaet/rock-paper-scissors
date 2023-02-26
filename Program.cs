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

            for (int i = 0; i < 5; i++)
            {
                getComputerChoice();
                getPlayerChoice();
                checkWinner();
            }

            void getComputerChoice()
            {
                Random rnd = new();
                computerChoice = shapes[rnd.Next(0, 3)];
                Console.WriteLine(computerChoice);
            }

            void getPlayerChoice()
            {
                Console.Write("Enter Rock, Paper, or Scissors: ");
                playerChoice = Console.ReadLine().ToLower();
            }

            void checkWinner()
            {
                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("RESULT: Draw");
                }
                else if (playerChoice == "rock")
                {
                    if (computerChoice == "scissors") Console.WriteLine("RESULT: Player wins");
                    if (computerChoice == "paper") Console.WriteLine("RESULT: Computer wins");
                }
                else if (playerChoice == "paper")
                {
                    if (computerChoice == "rock") Console.WriteLine("RESULT: Player wins");
                    if (computerChoice == "scissors") Console.WriteLine("RESULT: Computer wins");
                }
                else if (playerChoice == "scissors")
                {
                    if (computerChoice == "paper") Console.WriteLine("RESULT: Player wins");
                    if (computerChoice == "rock") Console.WriteLine("RESULT: Computer wins");
                }
            }
        }
    }
}