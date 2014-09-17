using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radix;
using Radix.Logging;
using Radix.Service;

namespace RadixConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomConsole.Init();

            var mainMenu = new MainMenu();
            mainMenu.Display();
        }
    }
}
