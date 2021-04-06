using System;

namespace gameLogic.Models
{
    public class GameLogic
    {
        bool running = true;

        public string Title { get; set; }


        public GameLogic(string title)
        {
            Title = title;
            Game();
        }

        public void Game()
        {
            while (running)
            {
                Console.WriteLine(Title);
                System.Console.WriteLine(@"Choose (R)ock, (P)aper, or (S)cissors R / P / S");
                string[] choices = new string[3]
                 {"Rock",
                 "Paper",
                "Scissors" };
                Random rand = new Random();
                int random = rand.Next(3);
                string compChoice = choices[random];
                Console.WriteLine();
                ConsoleKeyInfo userInput = System.Console.ReadKey();
                Console.Clear();



                if (userInput.Key == ConsoleKey.P && compChoice == "Scissors")
                {
                    System.Console.WriteLine("Computer Chose Scissors! You Lose");
                }
                else if (userInput.Key == ConsoleKey.P && compChoice == "Paper")
                {
                    System.Console.WriteLine("Computer Also Chose Scissors! You Tied");
                }
                else if (userInput.Key == ConsoleKey.P && compChoice == "Rock")
                {
                    System.Console.WriteLine("Computer Chose Scissors! You Win");
                }


                else if (userInput.Key == ConsoleKey.R && compChoice == "Scissors")
                {
                    System.Console.WriteLine("Computer Chose Scissors! You Win");
                }
                else if (userInput.Key == ConsoleKey.R && compChoice == "Paper")
                {
                    System.Console.WriteLine("Computer Chose Paper! You Lost");
                }
                else if (userInput.Key == ConsoleKey.R && compChoice == "Rock")
                {
                    System.Console.WriteLine("Computer Chose Rock! You tied");
                }



                else if (userInput.Key == ConsoleKey.S && compChoice == "Scissors")
                {
                    System.Console.WriteLine("Computer Chose Scissors! You Tied");
                }
                else if (userInput.Key == ConsoleKey.S && compChoice == "Paper")
                {
                    System.Console.WriteLine("Computer Chose Paper! You Win");
                }
                else if (userInput.Key == ConsoleKey.S && compChoice == "Rock")
                {
                    System.Console.WriteLine("Computer Chose Rock! You Lose");
                }
                else
                {
                    System.Console.WriteLine("invalid input");
                }
            }
        }


    }
}