using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice1Hypothese1
{
    class Baleine:Cetace
    {
        public Baleine(string nom, string habitation, string cri, bool domestique, int apnee, int profondeur)
            : base(nom, habitation, cri, domestique, apnee, profondeur)
        { }

        public void Afficher()
        {
            Console.WriteLine("Nom : {0} \n Lieu d'habitation : {1} \n Domestique : {2) \n Durée d'apnée : {3} \n Profondeur de plongée : {4}", nom, lieuHabitation, jeSuisDomestique, dureeApnee, profondeurPlongee);
        }
    }
}
