using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_3
{
    class Véhicule
    {
        protected string immatriculation;
        protected int annéeConstruct;
        protected string marque;
        protected string modele;

        public Véhicule(string immat, int anneeConstruct, string marque, string modele)
        {
            this.immatriculation = immat;
            this.annéeConstruct = anneeConstruct;
            this.marque = marque;
            this.modele = modele;
        }

        public void Afficher()
        {
            Console.WriteLine("Immatriculation : {0} \nAnnée de construction : {1} \nMarque : {2} \nModèle : {3}", this.immatriculation, this.annéeConstruct, this.marque, this.modele);
        }
    }
}
