using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice1Hypothese1
{
    class Felin : Mammifere
    {
        protected int nombrePattes;

        public Felin(string nom, string habitation, string cri, bool domestique, int pattes)
            : base(nom, habitation, cri, domestique)
        {
            this.nombrePattes = pattes;
        }
    }
}
