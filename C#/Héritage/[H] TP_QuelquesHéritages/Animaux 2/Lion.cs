using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice1Hypothese1
{
    class Lion:Felin
    {
        public Lion(string nom, string habitation, string cri, bool domestique, int pattes)
            : base(nom, habitation, cri, domestique, pattes)
        { }

        public void Afficher()
        {
            
        }
    }
}
