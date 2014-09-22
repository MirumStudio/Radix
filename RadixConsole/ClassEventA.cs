using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixConsole
{
    //Cette Classe montre les events c# de base, pas eux que j'ai coucue dans Radix


    //Ce delegate veut dire que sa doit etre une methode qui retourne void et qui prend un int en paramter
    public delegate void MyDelegate(int aParamater);

    public class ClassEventA
    {
        //Ceci est la declaration d'un event
        //Son nom est MyEvent et il est de type MyDelegate
        public event MyDelegate MyEvent;

        public void MethodeX(string aString)
        {
            //TRES INPORTANT, si l'event est a null, cela veut dire que personne est abonnee!!!
            if(MyEvent != null)
            {
                //On Dispatch l'event ! NOTE: le 4 ne signifie rien
                MyEvent(4);
            }
        }
    }
}
