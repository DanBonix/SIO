using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    class Waiter:Personne
    {
        protected Cook monCuisinier;
        protected Client monClient;
        protected Cashier leCaissier;

        public Waiter(string n, Cook unCuisinier, Cashier leCaissier)
            : base(n)
        {
            this.leCaissier = leCaissier;
            this.monCuisinier = unCuisinier;
        }

        public void OrderFood(Client monClient)
        {
            Console.WriteLine("Tu veux quoi ?");
            this.monClient = monClient;
            this.monClient.ServeWine();
            monCuisinier.OrderFood(this);
        }

        public void PickUp()
        {
            this.monClient.ServeFood(leCaissier);
        }
    }
}
