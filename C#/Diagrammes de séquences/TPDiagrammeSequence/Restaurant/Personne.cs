using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    class Personne
    {
        protected string nom;

        public Personne(string n)
        {
            this.nom = n;
        }

        public string Nom { get { return nom; } }
    }
}
