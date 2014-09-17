using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixConsole
{
    public abstract class ConsoleWindow : ConsoleUI
    {
        override public void Display()
        {
            CustomConsole.Clear();
            DisplayTitle();
            DisplayContent();
            CustomConsole.Pause();
            CustomConsole.Clear();
        }

        abstract protected void DisplayContent();
    }
}
