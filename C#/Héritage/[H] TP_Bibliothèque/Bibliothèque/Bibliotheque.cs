using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliothèque
{
    class Bibliotheque
    {
        private List <Etagere> lesEtageres;
        private List <Livre> lesLivres;

        public Bibliotheque()
        {}

        public Etagere nouvelleEtagere(Etagere e)
        {
            lesEtageres.Add(e);

            return e;
        }

        public Genre GetGenre(string libelleGenre)
        {
            for (int y = 0; y < lesEtageres.Count; y++)
            {
                for (int z = 0; z < lesEtageres[y].listeGenres.Count(); z++)
                {
                    if (
                }
            }
        }

        public Livre Nouveaulivre(string titre, string libelleGenre)
        {
            Livre nouveauLivre;
            Genre unGenre = this.GetGenre(libelleGenre);

            if (unGenre == null)
            {
                nouveauLivre = null;
            }

            else
            {
                nouveauLivre = new Livre(titre, unGenre);
                unGenre.PlaceLivre(nouveauLivre);
            }

            return nouveauLivre;
        }
    }
}
