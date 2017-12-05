using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice1Hypothese1
{
    class Mammifere
    {
        protected string nom;
        protected string lieuHabitation;
        protected string monCri;
        protected bool jeSuisDomestique;

        public Mammifere(string nom, string habitation, string cri, bool domestique)
        {
            this.nom = nom;
            this.lieuHabitation = habitation;
            this.monCri = cri;
            this.jeSuisDomestique = domestique;
        }

        public bool JeSuisDangereux()
        {
            return false;
        }
    }
}
