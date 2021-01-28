using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift1
{
    class WordGuessing
    {
        private string[] pool = { "Bread", "Drama", "Tea", "Wood", "Meat", "College", "Church",
        "Potato", "City", "Guitar", "Couch", "Engine", "Tennis", "Football", "Soccer",
        "Baseball","Player","Device","Phone","Computer","Bag","Shirt","Apple",
        "Table", "Chair","Onion","Broccoli","Tree","Floor","Flour","Cup","Soda",
        "Printer","Elevator"};
        private string[] answers;
        private string result;
        private string[] randomWords;

        public void Start()
        {
            WriteMenuText();
            ReadInput();
            ShowWords();
            GuessWords();
            WriteResult();
        }

        private void GuessWords()
        {
            int amountWrongGuesses = 1;
            int wordCount = 1;
            bool done = false;

            while(!done)
            {
                Console.WriteLine("Guess word " + wordCount.ToString());
                if(randomWords[wordCount - 1] == Console.ReadLine())
                {
                    if(wordCount == (randomWords.Length))
                    {
                        result = "You won!";
                        done = true;
                    }
                    wordCount++;
                } else
                {
                    if(amountWrongGuesses == 3)
                    {
                        result = "You guessed wrong 3 times, you lose :(";
                        done = true;
                    }

                    Console.WriteLine("Wrong guess, try again");
                    amountWrongGuesses++;
                }
            }

        }

        private void ReadInput()
        {
            int difficulty = InputClass.ReadIntegerConsole();

            switch (difficulty)
            {
                case 1:
                    difficulty = 3;
                    break;
                case 2:
                    difficulty = 5;
                    break;
                case 3:
                    difficulty = 7;
                    break;
            }

            randomWords = new string[difficulty];
            Random rnd = new Random();

            answers = new string[difficulty];

            for (int i = 1; i <= difficulty; i++)
            {
                int randomWordIndex = rnd.Next(0, pool.Length);
                randomWords[i - 1] = pool[randomWordIndex];
            }

            Console.Clear();
        }

        private void ShowWords()
        {
            for (int i = 0; i < randomWords.Length; i++)
            {
                Console.WriteLine(randomWords[i]);
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
        }

        private void WriteMenuText()
        {
            Console.Clear();
            Console.WriteLine("Select a level of difficulty (1-3):");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1: Easy (3 words)\n2: Medium (5 words)\n3: Hard (7 words)");
        }

        private void WriteResult()
        {
            Console.WriteLine(result);

            Console.WriteLine("\n\nEnter any key to continue...");
            Console.ReadLine();
        }
    }
}
