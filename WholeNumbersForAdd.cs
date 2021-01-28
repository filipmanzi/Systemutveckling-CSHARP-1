using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift1
{
    class WholeNumbersForAdd
    {
        private int numOfInput;
        private int sum;

        public void Start()
        {
            ReadInput();
        }

        private void ReadInput()
        {
            Console.Clear();
            Console.WriteLine("How many whole numbers would you like to sum?");

            numOfInput = InputClass.ReadIntegerConsole();

            SumNumbers();
        }

        private void ShowResults()
        {
            Console.Clear();
            Console.WriteLine("The sum is " + sum.ToString());

            Console.WriteLine("\n\nEnter any key to continue...");
            Console.ReadLine();
        }

        private void SumNumbers()
        {
            Console.Clear();
            
            for (int i = 1; i <= numOfInput; i++)
            {
                Console.WriteLine("Please enter number " + i.ToString());

                sum = sum + InputClass.ReadIntegerConsole();
            }

            ShowResults();
        }
    }
}
