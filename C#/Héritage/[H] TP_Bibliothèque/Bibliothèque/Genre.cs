using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliothèque
{
    class Genre
    {
        private string libelle;
        private Etagere lEtagere;
        private List<Livre> lesLivres;

        public Genre(string libelle, Etagere e)
        {
            this.libelle = libelle;
            this.lEtagere = e;
        }

        public void PlaceLivre(Livre unLivre)
        {
            int z = RangLivre(unLivre.GetTitre());

            lesLivres.Insert(z, unLivre);
        }

        private int RangLivre(string titre)
        {
            int z = 1;

            while ((z < lesLivres.Count) && (lesLivres[z].GetTitre().CompareTo(titre) == -1))
            {
                z++;
            }

            return z;
        }
    }
}
