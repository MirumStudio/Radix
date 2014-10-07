using Radix.Utlities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixConsole
{
    public abstract class ConsoleMenu : ConsoleUI
    {
        protected Dictionary<string, VoidDelegate> mMenuOption;

        protected ConsoleMenu()
        {
            mMenuOption = new Dictionary<string, VoidDelegate>();
        }

        override public void Display()
        {
            CustomConsole.Clear();
            DisplayTitle();
            DisplayMenuOptions();
            DisplayEnding();
            WaitMenuChoice();
            CustomConsole.Clear();
        }

        private void DisplayMenuOptions()
        {
            for(int i = 0; i < mMenuOption.Count; i++)
            {
                CustomConsole.Write((i + 1) + ".  " + mMenuOption.ElementAt(i).Key);
            }

            CustomConsole.Write((mMenuOption.Count + 1) + ".  Quit");
        }

        private void DisplayEnding()
        {
            CustomConsole.Write("\n********************************", ConsoleColor.Green);
            CustomConsole.Write("Enter number of the menu:");
        }

        private void WaitMenuChoice()
        {
            HandleMenuChoice(CustomConsole.ReadString());
        }

        private void HandleMenuChoice(string aChoice)
        {
            int choiceIndex = -1;
            try
            {
                choiceIndex = ConvertChoice(aChoice);   
            }
            catch (Exception)
            {
                DisplayErrorMessage();
            }

            if (choiceIndex >= 0)
            {
                CallChosenMenuOptionCallback(choiceIndex);
            }
        }

        private int ConvertChoice(string aChoice)
        {
            int choiceIndex = 0;
            choiceIndex = Convert.ToInt16(aChoice);
            choiceIndex--;
            return choiceIndex;
        }

        private void CallChosenMenuOptionCallback(int aChoiceIndex)
        {
            if (aChoiceIndex == mMenuOption.Count)
            {
                //Nothing, the menu is closing...
            }
            else
            {
                mMenuOption.ElementAt((int)aChoiceIndex).Value();
            }
        }

        private void DisplayErrorMessage()
        {
            CustomConsole.Clear();
            CustomConsole.Write("This choice is invalid...", ConsoleColor.Red);
            CustomConsole.Pause();
            Display();
        }
    }
}
