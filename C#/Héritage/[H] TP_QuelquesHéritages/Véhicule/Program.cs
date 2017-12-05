using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Véhicule[] Tab = new Véhicule[4];

            Tab[0] = new Voiture("333 ABC 06", 2000, "Peugeot", "306", true, false);
            Tab[1] = new Voiture("321 BBD 06", 2001, "Renault", "Clio", false, true);
            Tab[2] = new Camion("1234 TZ 06", 1993, "DAF", "T43", true, 4);
            Tab[3] = new Camion("765 ACE 06", 1999, "Mercedes", "C.L", false, 3);

            for (int z = 0; z < Tab.Length; z++)
            {
                if (Tab[z] is Voiture)
                {
                    ((Voiture)Tab[z]).Afficher();
                    Console.Write("\n");
                }

                else
                {
                    ((Camion)Tab[z]).Afficher();
                    Console.Write("\n");
                }
            }

            Console.ReadLine();

        }
    }
}
