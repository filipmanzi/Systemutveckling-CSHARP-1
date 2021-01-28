using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift1
{
    class CurrencyConverter
    {
        private bool isRunning = false;
        private double sum = 0.0;

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("Write 0 to finish. Make sure to use correct decimal character.");

            isRunning = true;
            ReadInput();
        }

        private void ReadInput()
        {
            string foreignCurrency;
            double exchangeRate;

            do
            {
                Console.WriteLine("Write an amount or zero to finish.");

                double userChoice = InputClass.ReadDoubleConsole();

                if (userChoice == 0.0)
                    isRunning = false;

                sum = sum + userChoice;
            }
            while (isRunning);

            Console.WriteLine("Choice of foreign currency:");
            foreignCurrency = Console.ReadLine();

            Console.WriteLine("Exchange rate:");
            exchangeRate = InputClass.ReadDoubleConsole();

            Calculate(foreignCurrency, exchangeRate);
        }

        private void Calculate(string foreignCurrency, double exchangeRate)
        {
            double convertedSum =  sum / exchangeRate;

            ShowResults(foreignCurrency, convertedSum, exchangeRate);
        }

        private void ShowResults(string foreignCurrency, double result, double rate)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("The sum is: " + sum.ToString() + "\n\n");

            Console.WriteLine(sum.ToString() + " kr is converted to: " + result.ToString() + " " + foreignCurrency + " at the rate of: " + rate + " Kr/" + foreignCurrency);

            Console.WriteLine("\n\nEnter any key to continue...");
            Console.ReadLine();

        }
    }
}
