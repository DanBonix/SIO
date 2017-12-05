using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concession
{
    class Modele
    {
        //Dan BONIX 2BTS SIO

        //donnnées membres
        private string nom;
        private double prix;
        private List<Option> optionsModele;

        public Modele(string nom, double prix)
        {
            this.nom = nom;
            this.prix = prix;
            optionsModele = new List<Option>();
        }

        public double GetPrix
        {
            get
            {
                return prix;
            }
        }

        public void AddOption(Option option)
        {
            optionsModele.Add(option);
        }

        public Option this[int index]
        {
            get
            {
                return this.optionsModele[index];
            }
        }

        public bool PossedeOption(string libelle)
        {
            bool option = false;

            for(int z=0;z<optionsModele.Count;z++)
            {
                if(libelle == optionsModele[z].GetLibelle())
                {
                    option = true;
                }
            }

            return option;
        }

        public int Count
        {
            get
            {
                return this.optionsModele.Count;
            }
        }

        public override string ToString()
        {
            string modele;

            modele = "Modele : " + this.nom + "\nPrix : " + this.prix + "\n";

            for (int z = 0; z < optionsModele.Count; z++)
            {
                modele += optionsModele[z].ToString() + "\n";
            }

            return modele;
        }
    }
}
