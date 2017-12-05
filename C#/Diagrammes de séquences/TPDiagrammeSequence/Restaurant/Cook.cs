using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    class Cook:Personne
    {
        public Cook(string n)
            : base(n)
        {}

        public void OrderFood(Waiter unServeur)
        {
            Console.WriteLine("Grec complet salade tomates oignons, sans pain, sans salade, sans tomates, sans sauce et sans oignons, OK ça marche");
            unServeur.PickUp();
        }
    }
}
