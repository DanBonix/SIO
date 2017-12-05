using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concession
{
    class Vehicule
    {
        //Dan BONIX 2BTS SIO

        //données memebres
        private string immatriculation;
        private List<Option> optionsBase;

        public Vehicule(string immatriculation)
        {
            this.immatriculation = immatriculation;
            optionsBase = new List<Option>();
        }

        public void AddOption(Option option)
        {
            optionsBase.Add(option);
        }

        public bool possedeOption(string libelle)
        {
            bool option = false;

            for (int z = 0; z < optionsBase.Count; z++)
            {
                if (libelle == optionsBase[z].GetLibelle())
                {
                    option = true;
                }
            }

            return option;
        }

        public Option this[int index]
        {
            get
            {
                return this.optionsBase[index];
            }
        }

        public int Count
        {
            get
            {
                return this.optionsBase.Count;
            }
        }

        public override string ToString()
        {
            string vehicule;

            vehicule = "Véhicule : " + this.immatriculation + "\n";

            for (int z = 0; z < optionsBase.Count; z++)
            {
                vehicule +=  optionsBase[z].ToString() + "\n";
            }

            return vehicule;
        }
    }
}
