using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    class Client:Personne
    {
        Waiter leServeur;

        public Client(string n, Waiter unServeur)
            : base(n)
        {
            this.leServeur = unServeur;
        }

        public void SeMetATable(Waiter unServeur)
        {
            Console.WriteLine("Hey toi le serveur !");

            leServeur = unServeur;
            unServeur.OrderFood(this);
        }

        public void ServeWine()
        {
            Console.WriteLine("C'est pas trop tôt j'avais soif");
        }

        public void ServeFood(Cashier leCaissier)
        {
            Console.WriteLine("C'est pas trop tôt, j'avais faim");

            leCaissier.Pay();
        }
    }
}
