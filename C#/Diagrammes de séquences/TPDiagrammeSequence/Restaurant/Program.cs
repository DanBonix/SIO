using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Cook ck = new Cook("Hank");
            Cashier csh = new Cashier("Renee");
            Waiter w = new Waiter("Bob", ck, csh);
            Client c = new Client("Fred", w);

            c.SeMetATable(w);

            Console.ReadLine();
        }
    }
}
