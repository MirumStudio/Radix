using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixConsole
{
    public abstract class ConsoleUI
    {
        protected string mTitle;

        abstract public void Display();

        protected void DisplayTitle()
        {
            CustomConsole.Write("*******  " + mTitle + "  *******\n", ConsoleColor.Green);
        }
    }
}
