using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_3
{
    class Camion:Véhicule
    {
        protected bool semiRemorque;
        protected int nbEssieux;

        public Camion(string immat, int anneeConstruct, string marque, string modele, bool semi, int essieux)
            : base(immat, anneeConstruct, marque, modele)
        {
            this.semiRemorque = semi;
            this.nbEssieux = essieux;
        }

        public new void Afficher()
        {
            if (semiRemorque == true)
            {
                Console.Write("Semi remorque ");
            }

            else
            {
                Console.Write("Camion ");
            }
            
            Console.WriteLine("avec {0} essieux", nbEssieux);

            base.Afficher();
        }
    }
}
