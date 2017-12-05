using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concession
{
    class Option
    {
        //Dan BONIX 2BTS SIO

        //données membres
        private string libelle;
        private double prix;

        public Option(string libelle, double prix)
        {
            this.libelle = libelle;
            this.prix = prix;
        }

        public double GetPrix() { return prix; }
        public string GetLibelle() { return libelle; }
        public override string ToString() { return String.Format("{0} : {1} euros", this.libelle, this.prix);}
    }
}
