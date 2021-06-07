using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleApp3.Project
{
    static class ConsoleUtils
    {
        public static void WaitForKeyPress()
        {
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.Yellow;
            WriteLine("");
            WriteLine("Press any key to continue.");
            ResetColor();
            ReadKey(true);
        }
        public static void QuitConsole()
        {
            WriteLine("");
            WriteLine("Press any key to exit.");
            ReadKey(true);
            Environment.Exit(0);
        }
    }
}
