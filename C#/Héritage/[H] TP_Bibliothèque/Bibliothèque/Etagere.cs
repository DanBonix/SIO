using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliothèque
{
    class Etagere
    {
        private int numero;
        private List<Genre> lesGenres;

        public Etagere(int n)
        {
            this.numero = n;
        }

        public List <Genre> listeGenres
        {
            get
            {
                return this.lesGenres;
            }
        }
    }
}
