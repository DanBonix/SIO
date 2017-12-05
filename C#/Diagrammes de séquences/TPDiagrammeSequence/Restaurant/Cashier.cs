using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    class Cashier:Personne
    {
        public Cashier(string n)
            : base(n)
        {}

        public void Pay()
        {
            Console.WriteLine("Par ici la monnaie et plus vite que ça");
        }
    }
}
