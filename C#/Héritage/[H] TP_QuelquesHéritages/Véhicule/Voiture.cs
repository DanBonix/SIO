using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_3
{
    class Voiture:Véhicule
    {
        protected bool decapotable;
        protected bool climatisation;

        public Voiture(string immat, int anneeConstruct, string marque, string modele, bool decapotable, bool clim)
            : base(immat, anneeConstruct, marque, modele)
        {
            this.decapotable = decapotable;
            this.climatisation = clim;
        }

        public new void Afficher()
        {
            if (decapotable == true)
            {
                Console.Write("Voiture décapotable ");
            }

            else
            {
                Console.Write("Voiture non décapotable ");
            }

            if (climatisation == true)
            {
                Console.WriteLine("avec climatisation");
            }

            else
            {
                Console.WriteLine("sans climatisation");
            }

            base.Afficher();
        }
    }
}
