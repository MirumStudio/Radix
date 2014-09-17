using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixConsole
{
    public class MainMenu : ConsoleMenu
    {
        public MainMenu()
        {
            mTitle = "Main Menu";
            mMenuOption.Add("Debugging", DisplayDebugWindows);
            mMenuOption.Add("Unit Test", DisplayTestWindows);
        }

        private void DisplayDebugWindows()
        {
            var window = new DebugWindow();
            window.Display();
            Display();
        }

        private void DisplayTestWindows()
        {
            var window = new TestWindow();
            window.Display();
            Display();
        }
    }
}
