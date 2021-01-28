using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift1
{
    class InputClass
    {
        public static int ReadIntegerConsole()
        {
            return int.Parse(Console.ReadLine());
        }

        public static double ReadDoubleConsole()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}
