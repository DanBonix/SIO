using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MereFille
{
    public partial class FMere : Form
    {
        private List<FFille> mesFilles;
        private int nombreFille;
        private string nomMere;

        public FMere()
        {
            InitializeComponent();

            this.Text = "Mère";
            this.nomMere = "Maman";

            mesFilles = new List<FFille>();

            btnNew.Click += new EventHandler(btnNew_Click);
            btnNew.Click += new EventHandler(btnNew_Click_Message);
            btnShow.Click += new EventHandler(btnShow_Click);
            btnHide.Click += new EventHandler(btnHide_Click);
            btnShowDialog.Click += new EventHandler(btnShowDialog_Click);
            btnClose.Click += new EventHandler(btnClose_Click);
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.mesFilles[lbLesFilles.SelectedIndex].Close();
            }
        }

        void btnShowDialog_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.mesFilles[lbLesFilles.SelectedIndex].ShowDialog();
            }
        }

        void btnHide_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.mesFilles[lbLesFilles.SelectedIndex].Hide();
            }
        }

        void btnShow_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.mesFilles[lbLesFilles.SelectedIndex].Show();
            }
        }

        void btnNew_Click_Message(object sender, EventArgs e)
        {
            MessageBox.Show("Une fenêtre fille a été instanciée");
        }

        void btnNew_Click(object sender, EventArgs e)
        {
            FFille nouvelleFille;
            nombreFille = nombreFille + 1;
            nouvelleFille = new FFille(this, nombreFille);
            mesFilles.Add(nouvelleFille);
            lbLesFilles.Items.Add("Fille n° " + this.nombreFille);
        }

        public void MaFilleChangeDeNom(FFille ffille, string nouveauNom)
        {
            
        }

        public string NomMere
        {
            get
            {
                return this.nomMere;
            }
        }
    }
}
