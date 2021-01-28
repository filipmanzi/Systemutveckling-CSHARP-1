using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift1
{
    class TemperatureConverter
    {
        public void Start()
        {
            WriteMenuText();

            for (int i = 0; i < 99; i += 4)
            {
                Console.WriteLine(i + ".00 F = " + Math.Round(5.0 / 9.0 * (i - 32), 2) + " C");
            }

            Console.WriteLine("\nEnter any key to continue...");
            Console.ReadLine();
        }

        private void WriteMenuText()
        {
            Console.Clear();
            Console.WriteLine("Temperature Table");
            Console.WriteLine("Changing Celsius (C) to Fahrenheit (F)");
            Console.WriteLine("----------------------");
        }
    }
}
