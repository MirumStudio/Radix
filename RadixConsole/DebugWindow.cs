using Radix.Logging;
using Radix.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixConsole
{
    public class DebugWindow : ConsoleWindow
    {
        public DebugWindow()
        {
            mTitle = "Debugging";
        }

        protected override void DisplayContent()
        {
            //Code test pour les log
            //var log = LogEntry.Create(ELogType.DEBUG, "Allo !");
           // CustomConsole.Write(log.mMessage);


            var classA = new ClassEventA();

            //Ici, on dit a la classeA de m'avertir quand MyEvent est dispactcher dans la MethodeA
            //MethodeA a la meme signature que MyDelegate
            classA.MyEvent += MethodeA;

            CustomConsole.Write("entre un character");
            classA.MethodeX(CustomConsole.ReadString());

            //Tres Important ! Sinon sa cree un memory leak !
            classA.MyEvent -= MethodeA;


            EventListener.Register(EEventTest.TEST1, MethodeB);

            var classB = new ClassEventB();
            CustomConsole.Write("entre un character");
            classB.MethodeX(CustomConsole.ReadString());

            //L'avantage de faire sa par rapport au -= est que nous sommes pas 
            //obliger de connaitre l'instance de la ClassEventB (l'objet classB)
            //Bref, on peut executer cette ligne nimporte ou 
            //Par exemple, lors de changement de scene etc
            EventService.UnregisterAllEventListener(typeof(ClassEventB));
        }


        private void MethodeA(int aInt)
        {
            CustomConsole.Write("\n On m'avertie !!, parametre: " + aInt);
        }

        //il me manque de faire en sorte qu'on recoit un int
        private void MethodeB(Enum _event, object _args)
        {
            CustomConsole.Write("\n On m'avertie !!, parametre: " + _event + " / " + (int)_args);
        }
    }
}
