using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift1
{
    class RockPaperScissors
    {
        private string[] options = { "Rock", "Paper", "Scissors" };
        private int userInput;
        private string winner;

        public void Start()
        {
            WriteMenuText();
            ReadInput();
            CompareHands();
            WriteResult();
        }

        private string GenerateHand()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 3);

            return options[num];
        }

        private void ReadInput()
        {
            bool badInput = true;

            while(badInput)
            {
                int input = InputClass.ReadIntegerConsole();

                if (input > 0 && input < 4)
                {
                    badInput = false;
                    userInput = input;
                    return;
                }

                Console.WriteLine("Wrong input, try again!\n\n");
            }

        }

        private void CompareHands()
        {
            string userChoice = options[userInput - 1];
            string computerChoice = GenerateHand();

            Console.Clear();
            Console.WriteLine("You picked " + userChoice);
            Console.WriteLine("Computer picked " + computerChoice);

            switch (userChoice)
            {
                case "Rock":
                    switch(computerChoice)
                    {
                        case "Rock":
                            winner = "Tie";
                            break;
                        case "Paper":
                            winner = "Computer";
                            break;
                        case "Scissors":
                            winner = "User";
                            break;
                    }
                    break;
                case "Paper":
                    switch (computerChoice)
                    {
                        case "Rock":
                            winner = "User";
                            break;
                        case "Paper":
                            winner = "Tie";
                            break;
                        case "Scissors":
                            winner = "Computer";
                            break;
                    }
                    break;
                case "Scissors":
                    switch (computerChoice)
                    {
                        case "Rock":
                            winner = "Computer";
                            break;
                        case "Paper":
                            winner = "User";
                            break;
                        case "Scissors":
                            winner = "Tie";
                            break;
                    }
                    break;
            }
        }

        private void WriteMenuText()
        {
            Console.Clear();
            Console.WriteLine("Choose a number:");
            Console.WriteLine("1: Rock\n\n2: Paper\n\n3: Scissors\n\n-------------------------");
        }

        private void WriteResult()
        {
            Console.WriteLine("-----------------\n");

            switch (winner)
            {
                case "Computer":
                    Console.WriteLine("Computer win!");
                    break;
                case "User":
                    Console.WriteLine("You win!");
                    break;
                case "Tie":
                    Console.WriteLine("It's a tie!");
                    break;
            }

            Console.WriteLine("\n-----------------");
            Console.WriteLine("Enter any key to continue...");
            Console.ReadLine();
        }
    }
}
