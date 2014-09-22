using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radix.Event;

namespace RadixConsole
{
    //Comme les delegates mais c juste un enum X
    public enum EEventTest
    {
        TEST1,
        TEST2
    }

    public class ClassEventB
    {
        public void MethodeX(string aString)
        {
           /* //TRES INPORTANT, si l'event est a null, cela veut dire que personne est abonnee!!!
            if (MyEvent != null)
            {
                //On Dispatch l'event ! NOTE: le 4 ne signifie rien
                MyEvent(4);
            }*/


            //Plus simple que les events de base de C# !!! HEHE
            EventService.DipatchEvent(EEventTest.TEST1, 4);
        }
    }
}
