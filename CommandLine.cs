using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA.Homework2
{
    /// <summary>
    /// CommandLine class is intended for UI
    /// </summary>
    public static class CommandLine
    {
        /// <summary>
        /// Gives user abbility to choose how to autorize
        /// </summary>
        public static void PrintUserTypes()
        {
            Console.WriteLine("Enter 1 to sign in as Administrator");
            Console.WriteLine("Enter 2 to sign in as Editor");
            Console.WriteLine("Enter 3 to sign in as Guest");
        }
        /// <summary>
        /// repeats what user's input until user tipes "exit" in a different color
        /// </summary>
        public static void RepeatInput()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n*** Print smth and I'll repeat or print 'exit' if you don't want to waste your time :( ***");
            string input = Console.ReadLine();
            while (!input.Equals("exit"))
            {
                Console.WriteLine(input);
                input = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
