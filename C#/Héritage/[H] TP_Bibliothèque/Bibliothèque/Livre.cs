using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliothèque
{
    class Livre
    {
        private string titre;
        private Genre leGenre;

        public Livre(string titre, Genre unGenre)
        {
            this.titre = titre;
            this.leGenre = unGenre;

            this.leGenre.PlaceLivre(this);
        }

        public string GetTitre()
        {
            return titre;
        }
    }
}
