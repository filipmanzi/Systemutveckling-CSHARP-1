using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift1
{
    class Menu
    {
        public void Start()
        {
            WholeNumbersForAdd opt1 = new WholeNumbersForAdd();
            CurrencyConverter opt2 = new CurrencyConverter();
            RockPaperScissors opt3 = new RockPaperScissors();
            WordGuessing opt4 = new WordGuessing();
            TemperatureConverter opt5 = new TemperatureConverter();

            WriteMenuText();

            int userChoice = InputClass.ReadIntegerConsole();

            switch (userChoice)
            {
                case 1:
                    opt1.Start();
                    break;
                case 2:
                    opt2.Start();
                    break;
                case 3:
                    opt3.Start();
                    break;
                case 4:
                    opt4.Start();
                    break;
                case 5:
                    opt5.Start();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }

            Start();
        }

        public void WriteMenuText()
        {
            Console.Clear();
            Console.WriteLine("         MAIN MENU           \n\n");
            Console.WriteLine("Whole Numbers with For       :1");
            Console.WriteLine("Currency Converter           :2");
            Console.WriteLine("Rock-Paper-Scissors          :3");
            Console.WriteLine("Word Guessing                :4");
            Console.WriteLine("Temperature Converter        :5");
            Console.WriteLine("Exit                         :0");
        }
    }
}
