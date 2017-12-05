using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MereFillev2
{
    public partial class FFille : Form
    {
        private string monNom;
        private FMere2 maMere;

        public FFille(FMere2 maMere, int numero)
        {
            InitializeComponent();
            this.Text = "Fille n° " + numero;
            this.monNom = this.Text;
            this.maMere = maMere;
            btnMaMere.Click += new EventHandler(btnMaMere_Click);
            this.FormClosing += new FormClosingEventHandler(FFille_FormClosing);
            this.Load += new EventHandler(FFille_Load);
            btnChangeNom.Click += new EventHandler(btnChangeNom_Click);
        }

        void btnChangeNom_Click(object sender, EventArgs e)
        {
            this.ChangerNom(tbNomFille.Text);
        }

        void FFille_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Evènement Load sur" + this.monNom);
        }

        void FFille_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            MessageBox.Show("Tour désactivée");
        }

        void btnMaMere_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maMere.NomMere);
        }

        private void ChangerNom(string nouveauNom)
        {
            this.monNom = nouveauNom;
            this.Text = tbNomFille.Text;
        }
    }
}
