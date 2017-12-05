using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concession
{
    class Voiture:Vehicule
    {
        //Dan BONIX 2BTS SIO

        //données membres
        private Modele possede;


        public Voiture(string immatriculation, Modele modele)
            : base(immatriculation)
        {
            this.possede = modele;
        }
        

        public double CalculerPrix()
        {
            double prix = 0;
            prix = this.possede.GetPrix;

            for (int z = 0; z < this.possede.Count; z++)
            {
                prix = prix + this.possede[z].GetPrix();
            }

            for (int z = 0; z < this.Count; z++)
            {
                prix = prix + this[z].GetPrix();
            }

            return prix;
        }

        public override string ToString()
        {
            return String.Format("" + this.possede.ToString() + "\n" + base.ToString() + "\n" + "Prix Total : " + this.CalculerPrix() + " euros");
        }
    }
}
