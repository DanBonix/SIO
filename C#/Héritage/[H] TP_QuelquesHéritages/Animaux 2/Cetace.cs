using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice1Hypothese1
{
    class Cetace : Mammifere
    {
        protected int dureeApnee;
        protected int profondeurPlongee;

        public Cetace(string nom, string habitation, string cri, bool domestique, int apnee, int profondeur)
            : base(nom, habitation, cri, domestique)
        {
            this.dureeApnee = apnee;
            this.profondeurPlongee = profondeur;
        }
    }
}
