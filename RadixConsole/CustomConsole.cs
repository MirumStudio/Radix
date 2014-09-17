using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixConsole
{
    public class CustomConsole
    {
        private const string TITLE = "Radix Console Application";

        static public void Init()
        {
            Console.Title = TITLE;
            Console.SetWindowSize(Console.LargestWindowWidth / 2, Console.LargestWindowHeight / 2);
        }

        static public void Write(string aMessage, ConsoleColor aForegroundColor = ConsoleColor.White, ConsoleColor aBackgroundColor = ConsoleColor.Black)
        {
            Console.BackgroundColor = aBackgroundColor;
            Console.ForegroundColor = aForegroundColor;
            Console.WriteLine(aMessage);
        }

        static public string ReadString()
        {
            ConsoleKeyInfo info = Console.ReadKey();
            return info.KeyChar.ToString();
        }

        static public ConsoleKey ReadKey()
        {
            ConsoleKeyInfo info = Console.ReadKey();
            return info.Key;
        }

        static public void Pause()
        {
            Write("Press enter to continue...");
            Console.Read();
        }

        static public void Clear()
        {
            Console.Clear();
        }
    }
}
