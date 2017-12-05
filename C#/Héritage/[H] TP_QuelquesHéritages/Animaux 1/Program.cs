using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice1Hypothese1
{
    class Program
    {
        static void Main(string[] args)
        {
            Baleine b = new Baleine("Sharko", "La mer Noire", "Chant", false, 45, 3000);

            b.Afficher();
            Console.ReadLine();
        }
    }
}
