using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concession
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dan BONIX 2BTS SIO

            Modele m = new Modele("Clio", 12000);
            Voiture v = new Voiture("447qq95", m);

            //options de la voiture qui hérite de Vehicule
            Option CD = new Option("CD Audio", 230);
            Option air = new Option("Air conditionné", 395);

            v.AddOption(CD);
            v.AddOption(air);

            //options du modele
            Option direction = new Option("Direction Assistée", 250);
            Option airBag = new Option("AirBag", 320);

            m.AddOption(direction);
            m.AddOption(airBag);

            //affichage
            Console.WriteLine(v.ToString());

            Console.ReadLine();
        }
    }
}
